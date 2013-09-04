using SimpleContacts.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleContacts.Models;
using SimpleContacts.Data;
using System.Data.Entity;
using SimpleContacts.Data.Migrations;


namespace SimpleContacts.Adapters.Interfaces
{
    public interface IHomeAdapter
    {
        ListContactsViewModel GetListContactsViewModel();
    }
}