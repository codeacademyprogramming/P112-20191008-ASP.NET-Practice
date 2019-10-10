using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using CruiseDemo.Models;

namespace CruiseDemo.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        P112CruiseEntities db = new P112CruiseEntities();

        public ActionResult Login()
        {
            if (Session["Login"] != null && (bool)Session["Login"] == true)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpPost]
        public ActionResult Login(CruiseDemo.Models.Admin admin)
        {
            

            if (admin.Email == null || admin.Password == null)
            {
                Session["LoginError"] = "Email ve parol bosh qoyula bilmez";
                return View();
            }

            CruiseDemo.Models.Admin adm = db.Admins.FirstOrDefault(a => a.Email == admin.Email);
            if (adm != null)
            {
                bool isLogin = Crypto.VerifyHashedPassword(adm.Password, admin.Password);
                if (isLogin)
                {
                    Session["Login"] = true;
                    Session["Admin"] = adm;
                    return RedirectToAction("Index", "Home");
                }
            }

            Session["LoginError"] = "Email ve ya parol sehvdir";

            return View();
        }


        public ActionResult Logout()
        {
            Session["Login"] = null;
            Session["Admin"] = null;
            return RedirectToAction("Login");
        }

        [HttpGet]
        public ActionResult Register()
        {
            if (Session["Login"] == null || (bool)Session["Login"] == false)
            {
                return RedirectToAction("Login", "User");
            }

            return View();
        }

        [HttpPost]
        public ActionResult Register(Models.Admin admin)
        {
            if (Session["Login"] == null || (bool)Session["Login"] == false)
            {
                return RedirectToAction("Login", "User");
            }


            if (admin.Fullname == null || admin.Email == null || admin.Password == null)
            {
                Session["RegisterError"] = "Butun melumatlari doldurmalisiniz";
                return View();
            }

           Models.Admin adm =  db.Admins.FirstOrDefault(a => a.Email == admin.Email);
            if (adm != null)
            {
                Session["RegisterError"] = admin.Email + " artiq movcuddur";
                return View();
            }


            adm = new Models.Admin
            {
                Fullname = admin.Fullname,
                Email = admin.Email,
                Password = Crypto.HashPassword(admin.Password)
            };

            db.Admins.Add(adm);
            db.SaveChanges();


            Session["Login"] = null;
            return RedirectToAction("Login");
        }




        public ActionResult HashPass()
        {
            string hashed = Crypto.HashPassword("admin123");
            return Content(hashed);
        }
    }
}