using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMI.Core;
using GMI.Custom.Gmi_Sr.Ubl2.Cac;
using GMI.Custom.Gmi_Sr.Ubl2.Udt;

namespace GMI.Custom.Gmi_Sr.Ubl2.Ubl2Helpers {
    internal class AccountingSupplier {

        private readonly GMI_Session _session;
        private readonly string _customerId;

        private PartyType _party;

        /// <summary>
        /// Create instance of class filled with data
        /// from table nastavit (leasing company data)
        /// </summary>
        /// <param name="session"></param>
        public AccountingSupplier(GMI_Session session) {
            _session = session;
            _customerId = null;
        }

        /// <summary>
        /// If supplier is not leasing company, pass customer id
        /// to this constructor
        /// </summary>
        /// <param name="session"></param>
        /// <param name="customerId"></param>
        public AccountingSupplier(GMI_Session session, string customerId) {
            _session = session;
            _customerId = customerId;

            // todo implement this later if needed
            throw new NotImplementedException();
        }


        private SupplierPartyType _accountingSupplierParty;
        public SupplierPartyType AccountingSupplierParty => _accountingSupplierParty;

        /// <summary>
        /// Fills data about supplier from Nova database
        /// </summary>
        public void GetSupplierDataFromDb() {

            // todo check if this is always empty
            _accountingSupplierParty.CustomerAssignedAccountID = new IdentifierType();

            _party = Party.GetPartyDataFromDb(_session);
        }

    }
}
