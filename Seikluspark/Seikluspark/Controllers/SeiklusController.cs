using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Seikluspark.Controllers
{
    public class SeiklusController : Controller
    {
        // GET: Seiklus
        public ActionResult seikluspark()
        {
            return View();
        }
        public ActionResult ülevaade()
        {
            return View();
        }

    }
}