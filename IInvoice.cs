using GMI.Custom.Gmi_Sr.Ubl2;
using GMI.Custom.Gmi_Sr.Ubl2.Cac;
using System;

namespace Ubl {

    public abstract class Invoice {

        public Invoice(object invoiceSource) {
            _invoice = new InvoiceType();
            _invoiceSource = invoiceSource;
        }

        // todo change _invoiceSource to Tab_RacOut object
        protected object _invoiceSource;
        
        // todo change _supplierParty to Tab_Partner object
        protected object _supplierParty;

        // todo change _customerParty to Tab_Partner object
        protected object _customerParty;

        protected InvoiceType _invoice;

        public virtual void CreateInvoice() {

            SetID();
            SetIssueDate();
            SetDueDate();
            SetInvoiceTypeCode();
            SetNote();
            SetCurrency();
            SetInvoicePeriod();

        }


        protected abstract void SetID();

        protected abstract void SetIssueDate();

        protected abstract void SetDueDate();

        protected abstract void SetInvoiceTypeCode();

        protected abstract void SetNote();

        protected abstract void SetCurrency();


        #region InvoicePeriod

        protected virtual void SetInvoicePeriod() {

            _invoice.InvoicePeriod = new PeriodType[1];
            SetDescriptionCode();
        }

        protected abstract void SetDescriptionCode();

        #endregion


        #region ContractDocumentReference

        protected virtual void SetContractDocumentReference() {

            _invoice.ContractDocumentReference = new DocumentReferenceType[1];
            SetContractDocumentReferenceID();
        }

        protected abstract void SetContractDocumentReferenceID();

        #endregion


        #region AdditionalDocumentReference

        protected virtual void SetAdditionalDocumentReference() {

            _invoice.AdditionalDocumentReference = new DocumentReferenceType[1];
            _invoice.AdditionalDocumentReference[0].ID = _invoice.ID;

            _invoice.AdditionalDocumentReference[0].Attachment = new AttachmentType();
            SetAttachment();

        }

        protected abstract void SetAttachment();

        #endregion


        #region Party

        // todo check if this should be virtual method
        // todo pass Tab_Partner as parameter
        protected abstract PartyType GetParty(object _party);

        #endregion


        #region AccountingSupplierParty

        protected virtual void SetAccountingSupplierParty() {

            SetCustomerAssignedAccountID();

            _invoice.AccountingSupplierParty = new SupplierPartyType();
            _invoice.AccountingSupplierParty.Party = GetParty(_supplierParty);

        }


        protected abstract void SetCustomerAssignedAccountID();

        #endregion


        #region AccountingCustomerParty

        protected virtual void SetAccountingCustomerParty() {

            _invoice.AccountingCustomerParty = new CustomerPartyType();
            _invoice.AccountingSupplierParty.Party = GetParty(_customerParty);

        }

        #endregion


        #region Delivery

        protected virtual void SetDelivery() {

            _invoice.Delivery = new DeliveryType[1];
            SetActualDeliveryDate();

        }

        protected abstract void SetActualDeliveryDate();

        #endregion


        #region TaxTotal

        // todo next

        #endregion


    }
}
