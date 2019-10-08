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
            return View();
        }
    }
}