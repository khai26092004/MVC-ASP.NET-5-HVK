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
    public class HvkProductsController : Controller
    {
        private HvkK22CNTLesson11DbEntities db = new HvkK22CNTLesson11DbEntities();

        // GET: HvkProducts
        public ActionResult HvkIndex()
        {
            var hvkProduct = db.HvkProduct.Include(h => h.HvkCategory);
            return View(hvkProduct.ToList());
        }

        // GET: HvkProducts/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HvkProduct hvkProduct = db.HvkProduct.Find(id);
            if (hvkProduct == null)
            {
                return HttpNotFound();
            }
            return View(hvkProduct);
        }

        // GET: HvkProducts/Create
        public ActionResult Create()
        {
            ViewBag.HvkCateId = new SelectList(db.HvkCategory, "HvkID", "HvkCateName");
            return View();
        }

        // POST: HvkProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Hvkid2210900109,HvkProName,HvkQty,HvkPrice,HvkCateId,HvkActive")] HvkProduct hvkProduct)
        {
            if (ModelState.IsValid)
            {
                db.HvkProduct.Add(hvkProduct);
                db.SaveChanges();
                return RedirectToAction("HvkIndex");
            }

            ViewBag.HvkCateId = new SelectList(db.HvkCategory, "HvkID", "HvkCateName", hvkProduct.HvkCateId);
            return View(hvkProduct);
        }

        // GET: HvkProducts/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HvkProduct hvkProduct = db.HvkProduct.Find(id);
            if (hvkProduct == null)
            {
                return HttpNotFound();
            }
            ViewBag.HvkCateId = new SelectList(db.HvkCategory, "HvkID", "HvkCateName", hvkProduct.HvkCateId);
            return View(hvkProduct);
        }

        // POST: HvkProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Hvkid2210900109,HvkProName,HvkQty,HvkPrice,HvkCateId,HvkActive")] HvkProduct hvkProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hvkProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.HvkCateId = new SelectList(db.HvkCategory, "HvkID", "HvkCateName", hvkProduct.HvkCateId);
            return View(hvkProduct);
        }

        // GET: HvkProducts/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HvkProduct hvkProduct = db.HvkProduct.Find(id);
            if (hvkProduct == null)
            {
                return HttpNotFound();
            }
            return View(hvkProduct);
        }

        // POST: HvkProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            HvkProduct hvkProduct = db.HvkProduct.Find(id);
            db.HvkProduct.Remove(hvkProduct);
            db.SaveChanges();
            return RedirectToAction("HvkIndex");
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
