using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMI.Core.Data;
using GMI.Custom.Gmi_Sr.Ubl2.Cac;
using GMI.Custom.Gmi_Sr.Ubl2.Udt;

namespace GMI.Custom.Gmi_Sr.Ubl2.Ubl2Helpers {
    internal static class InvoiceLine {

        /// <summary>
        /// Gets invoice lines from database
        /// </summary>
        /// <param name="tabRacOut">Record from rac_out table</param>
        /// <returns></returns>
        public static InvoiceLineType[] GetInvoiceLineFromDb(Tab_RacOut tabRacOut) {

            var invoiceLineArr = new InvoiceLineType[1];

            invoiceLineArr[0] = GetInvoiceLine(tabRacOut);

            return invoiceLineArr;

        }

        

        private static InvoiceLineType GetInvoiceLine(Tab_RacOut tabRacOut) {

            var invoiceLine = new InvoiceLineType();

            invoiceLine.ID = "1".ToIdentifierType();
            invoiceLine.InvoicedQuantity = 1m.ToQuantityType();

            // todo check which amount goes here
            invoiceLine.LineExtensionAmount = tabRacOut.debit.ToAmountType();

            invoiceLine.TaxTotal = TaxTotal.GetTaxTotalFromDb(tabRacOut);
            invoiceLine.Item = GetItem(tabRacOut);
            
            // todo
            invoiceLine.Price = new PriceType();
            invoiceLine.Price.PriceAmount.currencyID = "RSD";
            invoiceLine.Price.PriceAmount.Value = tabRacOut.debit;

            return invoiceLine;

        }


        private static ItemType GetItem(Tab_RacOut tabRacOut) {
            
            var item = new ItemType();

            item.Description = new TextType[1];
            item.Description[0] = tabRacOut.opisdok.ToTextType();
            item.Name = tabRacOut.opisdok.ToNameType();

            // todo
            item.SellersItemIdentification = new ItemIdentificationType();
            item.SellersItemIdentification.ID = "1".ToIdentifierType();

            // todo
            item.ClassifiedTaxCategory = new TaxCategoryType[1];

            return item;

        }
    }
}
