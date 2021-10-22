using GMI.Custom.Gmi_Sr.Ubl2;
using GMI.Custom.Gmi_Sr.Ubl2.Cac;
using System;

namespace Ubl {

    public abstract class Invoice {

        public Invoice(object invoiceSource) {
            _invoice = new InvoiceType();
            _invoiceSource = invoiceSource;
        }

        protected object _invoiceSource;
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

        #region AccountingSupplierParty

        protected virtual void SetAccountingSupplierParty() {

            SetCustomerAssignedAccountID();

            _invoice.AccountingSupplierParty = new SupplierPartyType();
            SetParty();

        }


        protected abstract void SetCustomerAssignedAccountID();

        protected virtual void SetParty() {

        }



        #endregion



    }
}
