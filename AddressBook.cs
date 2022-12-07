using System.Collections.Generic;

namespace AddressBook
{
    public class AddressBook
    {
        Dictionary<string, Contact> contacts = new Dictionary<string, Contact>();

        public void AddContact(Contact contactObj)
        {
            contacts.Add(contactObj.Email, contactObj);
        }

        public Contact GetByEmail(string email)
        {
            foreach (Contact contact in contacts.Values)
            {
                if (contact.Email == email)
                {
                    return contact;
                }
            }
            return null;
        }


    }
}