using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleContacts.Adapters;
using SimpleContacts.Adapters.Interfaces;
using SimpleContacts.Models;

namespace SimpleContacts.Controllers
{
    public class HomeController : Controller
    {
        public IHomeAdapter _adapter;

        public HomeController(IHomeAdapter adapter)
        {
            _adapter = adapter;            
        }

        public HomeController()
        {
            _adapter = new HomeAdapter();
        }

        public ActionResult Index()
        {
            ViewBag.Message = "This is an example project which displays a simple list of contacts";
            var model = _adapter.GetListContactsViewModel();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
