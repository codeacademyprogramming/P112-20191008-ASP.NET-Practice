using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CruiseDemo.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {


        public ActionResult Index()
        {
            if (Session["Login"] == null || (bool)Session["Login"] == false)
            {
                return RedirectToAction("Login", "User");
            }


            return View();
        }
    }
}