using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HvkLesson07CF.Models;

namespace HvkLesson07CF.Controllers
{
    public class HvkbooksController : Controller
    {
        private HvkBookStore db = new HvkBookStore();

        // GET: Hvkbooks
        public ActionResult Index()
        {
            return View(db.Hvkbooks.ToList());
        }

        // GET: Hvkbooks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hvkbook hvkbook = db.Hvkbooks.Find(id);
            if (hvkbook == null)
            {
                return HttpNotFound();
            }
            return View(hvkbook);
        }

        // GET: Hvkbooks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hvkbooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HvkId,HvkBookId,HvkTitle,HvkAuthor,HvkYear,HvkPulisher,HvkPicture,HvkCategoryId")] Hvkbook hvkbook)
        {
            if (ModelState.IsValid)
            {
                db.Hvkbooks.Add(hvkbook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hvkbook);
        }

        // GET: Hvkbooks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hvkbook hvkbook = db.Hvkbooks.Find(id);
            if (hvkbook == null)
            {
                return HttpNotFound();
            }
            return View(hvkbook);
        }

        // POST: Hvkbooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HvkId,HvkBookId,HvkTitle,HvkAuthor,HvkYear,HvkPulisher,HvkPicture,HvkCategoryId")] Hvkbook hvkbook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hvkbook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hvkbook);
        }

        // GET: Hvkbooks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hvkbook hvkbook = db.Hvkbooks.Find(id);
            if (hvkbook == null)
            {
                return HttpNotFound();
            }
            return View(hvkbook);
        }

        // POST: Hvkbooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Hvkbook hvkbook = db.Hvkbooks.Find(id);
            db.Hvkbooks.Remove(hvkbook);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
