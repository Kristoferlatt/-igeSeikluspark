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
        public ActionResult ülevaade()
        {
            var model = db.Seikluspark.
               ToList();
            return View(model);
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

        // GET: Jalgrattaeksams/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Jalgrattaeksams/Create
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
                return RedirectToAction("Kohal");
            }

            return View(park);
        }
        

        // POST: Jalgrattaeksams/Register
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult osta([Bind(Include = "inimesed,käepaelad")] park park)
        {
            if (ModelState.IsValid)
            {
                db.Seikluspark.Add(park);
                db.SaveChanges();
                return RedirectToAction("Kohal");
            }

            return View(park);
        }
        // GET: Jalgrattaeksams/Edit/5
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

        // POST: Jalgrattaeksams/Edit/5
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
        // GET: Jalgrattaeksams/Edit/5
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
        // GET: Jalgrattaeksams/Delete/5
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

        // POST: Jalgrattaeksams/Delete/5
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