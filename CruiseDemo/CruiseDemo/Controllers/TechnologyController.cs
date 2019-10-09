using CruiseDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CruiseDemo.Controllers
{
    public class TechnologyController : BaseController
    {
        // GET: Technology
        public ActionResult Index()
        {
            TechnologyViewModel model = new TechnologyViewModel
            {
                Features = db.Features.Where(t => t.Place == "hero").ToList(),
                Testimonials = db.Testimonials.OrderBy(t => t.Ordering).ToList(),
                Advantages = db.Advantages.Where(a=>a.Page == "technology").ToList()
            };
            return View(model);
        }
    }
}