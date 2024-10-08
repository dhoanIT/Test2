using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace vd.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MyLink()
        {
            ViewBag.Message = "Liên Kết của tôi";
            return Redirect("https://www.youtube.com/");
        }
        public ActionResult Haui()
        {
            ViewBag.Message = "Liên Kết của tôi";
            return Redirect("https://www.facebook.com/");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}