using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using SimpleContacts.Data.Model;

namespace SimpleContacts.Data.Migrations
{
    public class Seeder
    {
        public static void Seed(SimpleContext context,
            bool seedContacts = true

            )
        {
            if (seedContacts) SeedContacts(context);

            context.SaveChanges();
        }

        private static void SeedContacts(SimpleContext context)
        {
            context.Contacts.AddOrUpdate(c => c.Name,
                new Contact() { ContactId = 1, Name = "Bob Smith", PhoneNumber = "707.345.6547" },
                new Contact() { ContactId = 2, Name = "Nick Teacher", PhoneNumber = "345.678.2345" },
                new Contact() { ContactId = 3, Name = "Yola Franks", PhoneNumber = "567.234.5678" },
                new Contact() { ContactId = 4, Name = "Frank Shoemaker", PhoneNumber = "345.234.6543" },
                new Contact() { ContactId = 5, Name = "Franny Dorba", PhoneNumber = "456.324.8654" },
                new Contact() { ContactId = 6, Name = "Tom Sellic", PhoneNumber = "934.593.6943" },
                new Contact() { ContactId = 7, Name = "Bob Sinatra", PhoneNumber = "345.888.3456" },
                new Contact() { ContactId = 8, Name = "Diana Ross", PhoneNumber = "346.324.6432" }
                );
        }
    }
}
