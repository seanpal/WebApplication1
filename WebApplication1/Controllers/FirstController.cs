using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public string Index()
        {
            return "This is my <b>default</b> action...";
        }

        public ActionResult Welcome()
        {
            return View();
        }
        public ActionResult Welcome1()
        {
            return View();
        }
    }
}