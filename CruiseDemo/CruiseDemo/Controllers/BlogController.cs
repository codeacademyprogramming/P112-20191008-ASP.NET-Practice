using CruiseDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CruiseDemo.Controllers
{
    public class BlogController : BaseController
    {
        // GET: Blog
        public ActionResult Index(int? page)
        {
            int p = page ?? 1;

            BlogViewModel model = new BlogViewModel
            {
                Blogs = db.Blogs.OrderByDescending(b => b.CreatedAt).Skip((p - 1) * 8).Take(8).ToList()
            };

            int pageCount = db.Blogs.Count() / 8;
            if (db.Blogs.Count() % 8 != 0)
            {
                pageCount++;
            }

            model.PageCount = pageCount;
            model.CurrentPage = p;


            return View(model);
        }

        public ActionResult Details()
        {
            return View();
        }


    }
}