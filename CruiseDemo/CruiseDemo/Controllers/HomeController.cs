using CruiseDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CruiseDemo.Controllers
{
    public class HomeController : BaseController
    {

        public ActionResult Index()
        {
            HomeViewModel model = new HomeViewModel
            {
                Advantages = db.Advantages.Where(a=> a.Page == "home").ToList(),
                Blogs = db.Blogs.OrderByDescending(b => b.CreatedAt).Take(4).ToList(),
                Features = db.Features.ToList(),
                Testimonials = db.Testimonials.OrderBy(t => t.Ordering).ToList()
            };
            return View(model);
        }

    }
}