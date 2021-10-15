using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMI.Core;
using GMI.Core.Data;
using GMI.Custom.Gmi_Sr.Ubl2.Cac;

namespace GMI.Custom.Gmi_Sr.Ubl2.Ubl2Helpers {
    internal static class TaxTotal {

        public static TaxTotalType[] GetTaxTotalFromDb(Tab_RacOut tabRacOut) {

            var taxTotalArr = new TaxTotalType[1];
            var taxTotal = new TaxTotalType();

            taxTotal.TaxAmount.currencyID = "RSD";
            taxTotal.TaxAmount.Value = tabRacOut.debit_davek;

            taxTotal.TaxSubtotal = GetTaxSubtotalFromDb(tabRacOut);

            taxTotalArr[0] = taxTotal;
            
            return taxTotalArr;

        }


        private static TaxSubtotalType[] GetTaxSubtotalFromDb(Tab_RacOut tabRacOut) {

            var taxSubtotalArr = new TaxSubtotalType[1];

            var taxSubtotal = new TaxSubtotalType();
            
            //todo check
            taxSubtotal.TaxableAmount.currencyID = "RSD";
            taxSubtotal.TaxableAmount.Value = tabRacOut.debit_neto - tabRacOut.neobdav;

            //todo check
            taxSubtotal.TaxAmount.currencyID = "RSD";
            taxSubtotal.TaxAmount.Value = tabRacOut.debit_davek;

            // todo check
            var taxCategory = new TaxCategoryType();
            taxCategory.ID = "B".ToIdentifierType();
            taxCategory.Percent = 20.ToPercentType();
            taxCategory.TaxScheme = new TaxSchemeType() {  ID = "VAT".ToIdentifierType() };
            taxSubtotal.TaxCategory = taxCategory;

            taxSubtotalArr[0] = taxSubtotal;

            return taxSubtotalArr;
        }
    }
}
