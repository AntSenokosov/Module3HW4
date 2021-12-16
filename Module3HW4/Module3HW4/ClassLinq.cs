using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW4
{
    public class ClassLinq
    {
        private List<Contact> _contacts;

        public ClassLinq()
        {
            _contacts = new List<Contact>();
        }

        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
        }

        public Contact FirstOfDefaultContact(string firstName)
        {
            var contact = _contacts.FirstOrDefault(f => f.FirstName == firstName);

            return contact;
        }

        public List<Contact> WhereContact(char litter)
        {
            var contacts = _contacts.Where(w => w.FullName.ElementAt(0) == litter).Select(s => s);

            return contacts.ToList();
        }

        public List<Contact> OrderByContact()
        {
            var contacts = _contacts.OrderBy(o => o.FullName);

            return contacts.ToList();
        }

        public bool AnyContact(string numberPhone)
        {
            var result = _contacts.Any(a => a.Phone == numberPhone);

            return result;
        }
    }
}
