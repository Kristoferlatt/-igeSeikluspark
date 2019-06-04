using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Seikluspark.Models;

namespace Seikluspark.Controllers
{
    public class SeiklusController : Controller
    {
        private seiklusContext db = new seiklusContext();
        // GET: Seiklus
        public ActionResult Kohal()
        {
            return View(db.Seikluspark.ToList());
        }
        public ActionResult ülevaade()
        {
            return View();
        }

    }
}