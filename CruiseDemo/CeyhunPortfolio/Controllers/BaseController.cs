using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CeyhunPortfolio.Models;

namespace CeyhunPortfolio.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        protected readonly CeyhunFreelancerProjectEntities db;
        public BaseController()
        {
            db = new CeyhunFreelancerProjectEntities();
        }
    }
}