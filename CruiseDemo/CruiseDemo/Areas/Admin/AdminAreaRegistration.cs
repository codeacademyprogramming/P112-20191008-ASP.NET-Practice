using System.Web.Mvc;

namespace CruiseDemo.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { controller = "User", action = "Login", id = UrlParameter.Optional },
                new string[] { "CruiseDemo.Areas.Admin.Controllers" }
            );
        }
    }
}