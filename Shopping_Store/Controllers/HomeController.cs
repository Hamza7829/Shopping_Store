using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shopping_Store.Controllers
{
    public class HomeController : Controller
    {
        Model db=new Model();

        public ActionResult IndexAdmin()
        {
            return View();
        }

        public ActionResult IndexCustomer()
        {
        

            return View();
        }

        public ActionResult login()
        {
           

            return View();
        }
        [HttpPost]
        public ActionResult login(Admin p)
        {
          var results=  db.Admins.Where(x=>x.Email==p.Email && x.Password==p.Password).Count();
            if (results==1)
            {
                return RedirectToAction("Index" ,"Admins");
            }
            else
            {
                ViewBag.name = "try again";
                return View();
            }
        }
    }
}