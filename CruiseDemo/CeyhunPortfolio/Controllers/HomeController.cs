using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CeyhunPortfolio.Models;

namespace CeyhunPortfolio.Controllers
{
    public class HomeController :  BaseController
    {
        public ActionResult Index()
        {
            HomeModelView model = new HomeModelView
            {
                Start = db.Starts.ToList(),
                Portfolios = db.Portfolios.ToList(),
                Abouts = db.Abouts.ToList()
            };

            ViewBag.PortfolioItems = model.Portfolios;
            ViewBag.Settings = db.Settings.FirstOrDefault();

            return View(model);
        }
    }
}