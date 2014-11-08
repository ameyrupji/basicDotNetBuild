using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestBuildLibrary;

namespace TestWebApp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            var example = new Example();
            ViewBag.Number = 10;
            ViewBag.FibonacciOfNumber = example.GetFibonacciNumber(10);
            return View();
        }
	}
}