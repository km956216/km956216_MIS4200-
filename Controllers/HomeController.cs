using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace km956216_MIS4200.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "MIS and Analytics";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "MIS and Analytics major";

            return View();
        }
    }
}