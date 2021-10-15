using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMI.Core;
using GMI.Custom.Gmi_Sr.Ubl2.Cac;

namespace GMI.Custom.Gmi_Sr.Ubl2.Ubl2Helpers {
    internal class AccountingCustomer {

        private readonly GMI_Session _session;
        private readonly string _customerId;

        private PartyType _party;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="session">Session</param>
        /// <param name="customerId">Customer ID</param>
        public AccountingCustomer(GMI_Session session, string customerId) {
            _session = session;
            _customerId = customerId;
        }

        private CustomerPartyType _customerPartyType;
        public CustomerPartyType AccountingCustomerParty => _customerPartyType;


        public void GetCustomerDataFromDb() {

            _party = Party.GetPartyDataFromDb(_session, _customerId);
        }

    }
}
