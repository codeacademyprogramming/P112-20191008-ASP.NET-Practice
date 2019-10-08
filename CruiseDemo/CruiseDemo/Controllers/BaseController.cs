using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CruiseDemo.Models;

namespace CruiseDemo.Controllers
{
    public class BaseController : Controller
    {

       protected readonly P112CruiseEntities db;

        public BaseController()
        {
            db = new P112CruiseEntities();
            ViewBag.Settings = db.Settings.FirstOrDefault();
        }
    }
}