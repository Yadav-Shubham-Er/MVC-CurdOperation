using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Session5MVCmultitable.Controllers
{
    public class PartialViewDemoController : Controller
    {
        // GET: PartialViewDemo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PartialViewDemo()
        {
            return View();
        }
    }
}