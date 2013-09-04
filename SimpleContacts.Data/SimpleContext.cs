using SimpleContacts.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SimpleContacts.Data
{
    public class SimpleContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
    }
}
