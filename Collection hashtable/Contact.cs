using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    class Contact
    {
        public string ContactName { get; set; }
        public string PhoneNumber { get; set; }
        public Contact() {
            this.ContactName = string.Empty;
            this.PhoneNumber = string.Empty;
        }
        public Contact(string contactname,string phone) {
            this.ContactName = contactname;
            this.PhoneNumber = phone;
        }
    }
}
