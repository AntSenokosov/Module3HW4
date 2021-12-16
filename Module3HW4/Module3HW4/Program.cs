using System;

namespace Module3HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            var del = new ClassDelegate();

            del.EventSum += del.SumFunc;
            del.EventSum += del.SumFunc;

            del.SumResult(3, 5);
            del.SumResult(1, 3);

            Console.WriteLine("Sum = " + del.Sum);

            var linq = new ClassLinq();

            linq.AddContact(new Contact { FirstName = "Anton", LastName = "Senokosov", Phone = "0997534950" });
            linq.AddContact(new Contact { FirstName = "Vlad", LastName = "Gricak", Phone = "06635336950" });
            linq.AddContact(new Contact { FirstName = "Yegor", LastName = "Tkachenko", Phone = "0995312450" });
            linq.AddContact(new Contact { FirstName = "Vlad", LastName = "Leva", Phone = "0665332950" });
            linq.AddContact(new Contact { FirstName = "Anrdey", LastName = "Senokosov", Phone = "093214450" });

            var firstcontact = linq.FirstOfDefaultContact("Vlad");
            Console.WriteLine($"First contact = {firstcontact.FullName} {firstcontact.Phone}");

            var listWhereContacts = linq.WhereContact('A');
            foreach (var contact in listWhereContacts)
            {
                Console.WriteLine($"WhereContact = {contact.FullName} {contact.Phone}");
            }

            var listOrderByContacts = linq.OrderByContact();
            foreach (var contact in listOrderByContacts)
            {
                Console.WriteLine($"OrderByContact = {contact.FullName} {contact.Phone}");
            }

            var boolContact = linq.AnyContact("0665332950");

            if (boolContact == true)
            {
                Console.WriteLine($"boolContact = Номер есть в списках контактов");
            }
            else
            {
                Console.WriteLine($"boolContact = Такого номера нет");
            }

            Console.ReadKey();
        }
    }
}
