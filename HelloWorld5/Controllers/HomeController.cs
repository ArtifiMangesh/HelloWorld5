using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            int  ab =1;
            int ab =2;
             int ab =3;

            string name = 12;
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
    }
}
