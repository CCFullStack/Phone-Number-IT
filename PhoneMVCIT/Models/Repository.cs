using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneMVCIT.Models {
    public class Repository {

        public static Customer Customer { get; set; }

        public Repository() {
            if (Customer == null) {
                Customer = new Customer {
                    FirstName = "Eric",
                    LastName = "Siebeneich",
                    PhoneNumber = "1234567890"
                };
            }
        }

        public IList<Customer> ListCustomers() {
            return new List<Customer> {
                Customer
            };
        }
    }
}