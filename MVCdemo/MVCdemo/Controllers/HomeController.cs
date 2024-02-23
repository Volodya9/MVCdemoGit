using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCdemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            string msg = "Hello world";
            return msg;
        }

        public string Demo()
        {
            return "Gde je ActionResult koji k...";
        }
    }
}