using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CruiseDemo.Models;

namespace CruiseDemo.Areas.Admin.Controllers
{
    public class CareersController : Controller
    {
        P112CruiseEntities db = new P112CruiseEntities();

        // GET: Admin/Careers
        public ActionResult Index()
        {

            if (Session["Login"] == null || (bool)Session["Login"] == false)
            {
                return RedirectToAction("Login", "User");
            }

            return View(db.Vacancies.ToList());
        }


        [HttpGet]
        public ActionResult Create()
        {

            if (Session["Login"] == null || (bool)Session["Login"] == false)
            {
                return RedirectToAction("Login", "User");
            }

            return View();
        }


        [HttpPost]
        public ActionResult Create(Vacancy vacancy)
        {
            if (Session["Login"] == null || (bool)Session["Login"] == false)
            {
                return RedirectToAction("Login", "User");
            }

            db.Vacancies.Add(vacancy);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}