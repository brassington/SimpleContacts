using SimpleContacts.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleContacts.Adapters.Interfaces;
using SimpleContacts.Models;
using System.Data.Entity;

namespace SimpleContacts.Controllers
{
    public class HomeAdapter : IHomeAdapter
    {
        public Models.ListContactsViewModel GetListContactsViewModel()
        {
            var model = new ListContactsViewModel();

            SimpleContext db = new SimpleContext();

            model.Contacts = db.Contacts.ToList();

            return model;
        }
    }
}
