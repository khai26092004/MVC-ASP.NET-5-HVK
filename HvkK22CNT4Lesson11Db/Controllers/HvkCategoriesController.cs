using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HvkK22CNT4Lesson11Db.Models;

namespace HvkK22CNT4Lesson11Db.Controllers
{
    public class HvkCategoriesController : Controller
    {
        private HvkK22CNTLesson11DbEntities db = new HvkK22CNTLesson11DbEntities();

        // GET: HvkCategories
        public ActionResult HvkIndex()
        {
            return View(db.HvkCategory.ToList());
        }

        // GET: HvkCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HvkCategory hvkCategory = db.HvkCategory.Find(id);
            if (hvkCategory == null)
            {
                return HttpNotFound();
            }
            return View(hvkCategory);
        }

        // GET: HvkCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HvkCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HvkID,HvkCateName,HvkStatus")] HvkCategory hvkCategory)
        {
            if (ModelState.IsValid)
            {
                db.HvkCategory.Add(hvkCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hvkCategory);
        }

        // GET: HvkCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HvkCategory hvkCategory = db.HvkCategory.Find(id);
            if (hvkCategory == null)
            {
                return HttpNotFound();
            }
            return View(hvkCategory);
        }

        // POST: HvkCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HvkID,HvkCateName,HvkStatus")] HvkCategory hvkCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hvkCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hvkCategory);
        }

        // GET: HvkCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HvkCategory hvkCategory = db.HvkCategory.Find(id);
            if (hvkCategory == null)
            {
                return HttpNotFound();
            }
            return View(hvkCategory);
        }

        // POST: HvkCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HvkCategory hvkCategory = db.HvkCategory.Find(id);
            db.HvkCategory.Remove(hvkCategory);
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
