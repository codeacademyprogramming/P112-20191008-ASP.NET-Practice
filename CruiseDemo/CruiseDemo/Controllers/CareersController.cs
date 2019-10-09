using CruiseDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CruiseDemo.Controllers
{
    public class CareersController : BaseController
    {
        // GET: Careers
        public ActionResult Index()
        {
            CareersViewModel model = new CareersViewModel
            {
                Advantages = db.Advantages.Where(a => a.Page == "careers").ToList(),
                Vacancies = db.Vacancies.ToList()
            };

            return View(model);
        }
    }
}