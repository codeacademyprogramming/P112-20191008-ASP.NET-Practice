using CruiseDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CruiseDemo.Controllers
{
    public class AboutController : BaseController
    {
        // GET: About
        public ActionResult Index()
        {
            AboutViewModel model = new AboutViewModel
            {
                AboutItems = db.AboutItems.ToList(),
                Employees = db.Employees.ToList(),
                Testimonials = db.Testimonials.OrderBy(t => t.Ordering).ToList(),
                Vacancies = db.Vacancies.ToList()
            };
            return View(model);
        }
    }
}