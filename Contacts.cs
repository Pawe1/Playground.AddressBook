using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Contacts
    {
        Contacts()
        {
            Items = new List<Contact>();
        }

        public List<Contact> Items { get; }
    }
}
