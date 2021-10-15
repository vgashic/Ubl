using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMI.Core;
using GMI.Core.Data;
using GMI.Custom.Gmi_Sr.Ubl2.Cac;
using GMI.Custom.Gmi_Sr.Ubl2.Ubl2Helpers;
using GMI.Custom.Gmi_Sr.Ubl2.Udt;

namespace GMI.Custom.Gmi_Sr.Ubl2 {
    internal class RacOutUbl {

        private readonly GMI_Session _session;
        private readonly string _ddvId;
        private Tab_RacOut _racOut;

        private InvoiceType _invoice;
        public InvoiceType Invoice => _invoice;

        public RacOutUbl(GMI_Session session, string ddvId) {
            _session = session;
            _ddvId = ddvId;

            _racOut = Tab_RacOut.CreateQuery()
                .IsEqual(Tab_RacOut.Columns.ddv_id, _ddvId)
                .GetList(_session)
                .FirstOrDefault();

            if (_racOut == null) {
                // todo throw more specific exception
                throw new UblExceptionBase($"Invoice [{_ddvId}] not exists");
            }
        }

        public RacOutUbl(GMI_Session session, Tab_RacOut racOut) {
            _session = session;
            _racOut = racOut;
            _ddvId = racOut.ddv_id;
        }


        public void CreateInvoice() {

            _invoice = new InvoiceType();

            var id = new IdentifierType() {
                Value = _racOut.st_dok
            };

            _invoice.IssueDate = new DateType() { Value = _racOut.datum };
            _invoice.DueDate = new DateType() { Value = _racOut.ddv_date };

            // todo get type code
            _invoice.InvoiceTypeCode = "380".ToCodeType();

            // todo remove hardcoded currency
            _invoice.DocumentCurrencyCode = "RSD".ToCodeType();

            // todo extract this
            _invoice.InvoicePeriod = GetInvoicePeriod(new[] { "0".ToCodeType() });

            _invoice.AdditionalDocumentReference = new[] {
                new DocumentReferenceType() { ID = new IdentifierType() { Value = _racOut.st_dok } },
                new DocumentReferenceType() { Attachment = new AttachmentType() }
            };

            #region AccountingSupplierParty

            var accountingSupplierParty = new AccountingSupplier(_session);
            accountingSupplierParty.GetSupplierDataFromDb();
            _invoice.AccountingSupplierParty = accountingSupplierParty.AccountingSupplierParty;

            #endregion


            #region AccountingCustomerParty

            var accountingCustomerParty = new AccountingCustomer(_session, _racOut.id_kupca);
            accountingCustomerParty.GetCustomerDataFromDb();
            _invoice.AccountingCustomerParty = accountingCustomerParty.AccountingCustomerParty;

            #endregion


            #region Delivery

            // todo check if datum is correct delivery date
            _invoice.Delivery = new DeliveryType[1];
            _invoice.Delivery[0].ActualDeliveryDate = _racOut.datum.ToDateType();

            #endregion


            #region TaxTotal

            _invoice.TaxTotal = TaxTotal.GetTaxTotalFromDb(_racOut);

            #endregion


            #region LegalMonetaryTotal

            // todo implement this
            _invoice.LegalMonetaryTotal = new MonetaryTotalType();

            #endregion


            #region InvoiceLine

            _invoice.InvoiceLine = InvoiceLine.GetInvoiceLineFromDb(_racOut);

            #endregion

        }


        /// <summary>
        /// Data about leasing issuer of invoice
        /// In our case, it's leasing company
        /// </summary>
        /// <returns></returns>
        private SupplierPartyType GetAccountingSupplier() {
            throw new NotImplementedException();
        }


        private PeriodType[] GetInvoicePeriod(CodeType[] descriptionCodes) {

            return new[] {
                new PeriodType() {
                    DescriptionCode = descriptionCodes }
            };
        }


    }
}
