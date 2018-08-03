using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Util;
using System.Web.Security;
namespace SkyBus.Controllers
{
    public class HomePageController : Controller
    {
        // 
        // GET: /HelloWorld/ 

        public ActionResult Index()
        {
            ViewData["Message"] = "Hello ";
            ViewData["Name"] = "Sky Bus";
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string name, int numTimes = 1)
        {
            return 
                "Hello " + name + ", NumTimes is: " + numTimes;
        }
    }
}