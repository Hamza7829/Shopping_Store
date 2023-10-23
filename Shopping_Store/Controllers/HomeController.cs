using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shopping_Store.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult IndexAdmin()
        {
            return View();
        }

        public ActionResult IndexCustomer()
        {
        

            return View();
        }

        public ActionResult Contact()
        {
           

            return View();
        }
    }
}