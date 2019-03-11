  /*
        1. Add the required classes to make the following code compile.
        HINT: Use a Dictionary in the AddressBook class to store Contacts. The key should be the contact's email address.
*/

using System;
namespace c_exceptions
{
        class Contact
    {
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public string Email {get;set;}
        public string Address {get;set;}

        public string FullName {get {return $"{FirstName} {LastName}";}}

        public Contact(string firstname, string email, string address) {
            FirstName = firstname;
            Email = email;
            Address = address;
        }

        public Contact()
        {
        }
    }
}
