using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.countries = new List<string>()
            {
                "India","US","UK","Canada"
            };

            ViewData["MyList"] = new List<string>()
            {
                "IRAN","Syria","Russia","====="
            };
            return View();
        }
    }
}