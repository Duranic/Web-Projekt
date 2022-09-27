using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Spam_Detection_Chat.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if ((System.Web.HttpContext.Current.User != null) && System.Web.HttpContext.Current.User.Identity.IsAuthenticated)
            {
                ViewBag.Flag = true;
                ViewBag.Message = System.Web.HttpContext.Current.User.Identity.Name;
            }
            else
            {
                ViewBag.Flag = false;
            }
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}