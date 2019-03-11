/*
   1. Add the required classes to make the following code compile.
   HINT: Use a Dictionary in the AddressBook class to store Contacts. The key should be the contact's email address.
*/

using System.Collections.Generic;

namespace c_exceptions
{
    class AddressBook
    {
        public  Dictionary<string, Contact> contacts {get;set;} = new Dictionary<string, Contact>();
        public void AddContact(Contact name){
            contacts.Add(name.Email, name);
        }
        public Contact GetByEmail(string email){
            return contacts[email];
        }
    }
}
