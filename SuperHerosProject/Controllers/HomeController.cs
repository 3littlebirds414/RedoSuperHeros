using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperHerosProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Just a little Web Application about SuperHeros.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Obvs not my real contact information.";

            return View();
        }
    }
}