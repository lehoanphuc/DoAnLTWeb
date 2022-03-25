using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnLTWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        public ActionResult Nikon()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Cannon()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Other()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Cart()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Lens()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Sony()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}