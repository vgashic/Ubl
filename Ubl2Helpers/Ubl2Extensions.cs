using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMI.Custom.Gmi_Sr.Ubl2.Udt;

namespace GMI.Custom.Gmi_Sr.Ubl2.Ubl2Helpers {
    internal static class Ubl2Extensions {

        public static CodeType ToCodeType(this string code) {
            return new CodeType() { Value = code };
        }


        public static NameType ToNameType(this string name) {
            return new NameType() { Value = name };
        }


        public static IdentifierType ToIdentifierType(this string type) {
            return new IdentifierType() { Value = type };
        }


        public static DateType ToDateType(this DateTime date) {
            return new DateType() { Value = date };
        }


        public static PercentType ToPercentType(this decimal percent) {
            return new PercentType() { Value = percent };
        }


        public static PercentType ToPercentType(this int percent) {
            return new PercentType { Value = Convert.ToDecimal(percent) };
        }


        public static QuantityType ToQuantityType(this decimal quantity) {
            return new QuantityType() { Value = quantity };
        }


        public static AmountType ToAmountType(this decimal amount) {
            return new AmountType() { Value = amount };
        }


        public static TextType ToTextType(this string text) {
            return new TextType() { Value = text };
        }

    }
}
