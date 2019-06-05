using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Seikluspark.Models;
using System.Net;

namespace Seikluspark.Controllers
{
    public class SeiklusController : Controller
    {
        private seiklusContext db = new seiklusContext();
        // GET: Seiklus
        public ActionResult osta()
        {
            return View();
        }
        public ActionResult inimesed()
        {
            
            return View();
        }
        public ActionResult käepaelad()
        {
            return View();
        }
        public ActionResult Kohal()
        {
            return View(db.Seikluspark.ToList());
        }
        public ActionResult sissetulek()
        {
            return View();
        }
        public ActionResult ülevaade()
        {
            return View(db.Seikluspark.ToList());
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            park park = db.Seikluspark.Find(id);
            if (park == null)
            {
                return HttpNotFound();
            }
            return View(park);
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult osta([Bind(Include = "Id,inimesed,käepaelad")] park park)
        {
            if (ModelState.IsValid)
            {
                db.Seikluspark.Add(park);
                db.SaveChanges();
                return RedirectToAction("ülevaade");
            }

            return View(park);
        }

        // GET: SeiklusPark/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Seikluspark/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,inimesed,käepaelad")] park park)
        {
            if (ModelState.IsValid)
            {
                db.Seikluspark.Add(park);
                db.SaveChanges();
                return RedirectToAction("ülevaade");
            }

            return View(park);
        }

        // GET: Seikluspark/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            park park = db.Seikluspark.Find(id);
            if (park == null)
            {
                return HttpNotFound();
            }
            return View(park);
        }

        // POST: Seikluspark/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,inimesed,käepaelad")] park park)
        {
            if (ModelState.IsValid)
            {
                db.Entry(park).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Kohal");
            }
            return View(park);
        }
        // GET: Seikluspark/Edit/5
        public ActionResult TheoryResult(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            park park = db.Seikluspark.Find(id);
            if (park == null)
            {
                return HttpNotFound();
            }
            return View(park);
        }
        // GET: Seikluspark/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            park park = db.Seikluspark.Find(id);
            if (park == null)
            {
                return HttpNotFound();
            }
            return View(park);
        }

        // POST: Seikluspark/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            park park = db.Seikluspark.Find(id);
            db.Seikluspark.Remove(park);
            db.SaveChanges();
            return RedirectToAction("Kohal");
        }

    }
}