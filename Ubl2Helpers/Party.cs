using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMI.Core;
using GMI.Core.Data;
using GMI.Custom.Gmi_Sr.Ubl2.Cac;

namespace GMI.Custom.Gmi_Sr.Ubl2.Ubl2Helpers {
    internal static class Party {

        /// <summary>
        /// Returns PartyType object for specified customer
        /// </summary>
        /// <param name="session">session</param>
        /// <param name="customerId">Customer id</param>
        /// <returns></returns>
        public static PartyType GetPartyDataFromDb(GMI_Session session, string customerId = null) {

            var party = new PartyType();

            var tabPartner = new Tab_Partner();

            if (customerId != null) {
                
                tabPartner = Tab_Partner.CreateQuery()
                    .IsEqual(Tab_Partner.Columns.id_kupca, customerId)
                    .GetList(session)
                    .FirstOrDefault();

                tabPartner = tabPartner ?? new Tab_Partner();

            } else {
                tabPartner = null;
            }

            // todo add custom setting
            party.EndpointID.schemeID = "9948";
            party.EndpointID.Value = GMI_Nastavit.Singleton.p_dav_stev;

            party.PartyIdentification = new PartyIdentificationType[1];

            party.PartyName = GetPartyName(tabPartner);
            party.PostalAddress = GetPartyPostalAddress(tabPartner);
            party.PartyTaxScheme = GetPartyTaxScheme(tabPartner);
            party.PartyLegalEntity = GetPartyLegalEntity(tabPartner);

            return party;
        }


        /// <summary>
        /// Gets supplier legal entity data
        /// </summary>
        /// <param name="tabPartner"></param>
        /// <returns></returns>
        private static PartyLegalEntityType[] GetPartyLegalEntity(Tab_Partner tabPartner = null) {

            var partyLegalEntityArr = new PartyLegalEntityType[1];
            var partyLegalEntity = new PartyLegalEntityType();

            // todo check if more data is needed
            if (tabPartner == null) {
                partyLegalEntity.RegistrationName = GMI_Nastavit.Singleton.p_podjetje.Trim().ToNameType();
                partyLegalEntity.CompanyID = GMI_Nastavit.Singleton.p_dav_stev.Trim().ToIdentifierType();
            } else {
                partyLegalEntity.RegistrationName = tabPartner.naz_kr_kup.Trim().ToNameType();
                partyLegalEntity.CompanyID = tabPartner.dav_stev.Trim().ToIdentifierType();
            }

            partyLegalEntityArr[0] = partyLegalEntity;

            return partyLegalEntityArr;
        }


        /// <summary>
        /// Gets supplier tax schemes
        /// </summary>
        /// <param name="tabPartner"></param>
        /// <returns></returns>
        private static PartyTaxSchemeType[] GetPartyTaxScheme(Tab_Partner tabPartner = null) {

            var partyTaxScheme = new PartyTaxSchemeType();
            var partyTaxSchemeArr = new PartyTaxSchemeType[1];

            partyTaxScheme.CompanyID = tabPartner == null ? GMI_Nastavit.Singleton.p_dav_stev.ToIdentifierType()
                : tabPartner.dav_stev.Trim().ToIdentifierType();

            // todo check possible schemes and add to general register
            partyTaxScheme.TaxScheme = new TaxSchemeType() { ID = "VAT".ToIdentifierType() };

            partyTaxSchemeArr[0] = partyTaxScheme;

            return partyTaxSchemeArr;

        }


        /// <summary>
        /// Returns postal address
        /// </summary>
        /// <param name="tabPartner"></param>
        /// <returns></returns>
        private static AddressType GetPartyPostalAddress(Tab_Partner tabPartner = null) {

            var postalAddress = new AddressType();

            // todo get identification codes register
            // todo add codes to general register
            postalAddress.Country = new CountryType() {
                IdentificationCode = "381".ToCodeType(),
                Name = "Serbia".ToNameType()
            };

            // todo add street and other address details if needed

            return postalAddress;

        }


        /// <summary>
        /// Gets party name
        /// If tabPartner is null, returns leasing company name
        /// </summary>
        /// <param name="tabPartner"></param>
        /// <returns></returns>
        private static PartyNameType[] GetPartyName(Tab_Partner tabPartner = null) {

            var partyName = new PartyNameType[1];

                partyName[0] = new PartyNameType() {
                    Name = tabPartner == null ? GMI_Nastavit.Singleton.p_podjetje.Trim().ToNameType()
                        : tabPartner.naz_kr_kup.Trim().ToNameType()
                };

            return partyName;

        }
    }
}
