using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.vb = "This is from VB";
            ViewData["vd"] = "This is from VD";
            TempData["td"] = "This is from TD";
            TempData.Keep();
            return View();
        }

        public string SayHello(string name)
        {
            return "Hello " + name;
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

        [NonAction]
        public void Add(int a, int b)
        {
            ViewBag.Result ="Addition result is: "+ (a + b);
        }
    }
}