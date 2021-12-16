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

        public Contact FirstOfDefaultContact(string fullName)
        {
            var contact = _contacts.FirstOrDefault(f => f.FullName == fullName);

            return contact;
        }

        public List<Contact> SelectContact(string numberPhone)
        {
            var contacts = _contacts.Select(s => s.Phone.StartsWith(numberPhone));

            return (List<Contact>)contacts;
        }

        public List<Contact> WhereContact(string litter)
        {
            var contacts = _contacts.Where(w => w.FullName.ToUpper() == litter);

            return (List<Contact>)contacts;
        }

        public List<Contact> OrderByContact(string numberPhone)
        {
            var contacts = _contacts.Where(w => w.Phone == numberPhone).OrderBy(o => o);

            return (List<Contact>)contacts;
        }

        public bool AnyContact(string numberPhone)
        {
            var result = _contacts.Any(a => a.Phone == numberPhone);

            return result;
        }

        public List<Contact> GroupByContact()
        {
            var contacts = _contacts.GroupBy(g => g.FullName);

            return (List<Contact>)contacts;
        }
    }
}
