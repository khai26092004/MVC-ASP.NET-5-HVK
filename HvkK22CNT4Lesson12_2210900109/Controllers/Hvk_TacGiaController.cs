using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace HvkK22CNT4Lesson12_2210900109.Controllers
{
    public class Hvk_TacGiaController : Controller
    {
        private HoangVanKhai_2210900109Entities db = new HoangVanKhai_2210900109Entities();

        // GET: Hvk_TacGia
        public ActionResult HvkIndex()
        {
            return View(db.Hvk_TacGia.ToList());
        }

        // GET: Hvk_TacGia/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hvk_TacGia hvk_TacGia = db.Hvk_TacGia.Find(id);
            if (hvk_TacGia == null)
            {
                return HttpNotFound();
            }
            return View(hvk_TacGia);
        }

        // GET: Hvk_TacGia/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hvk_TacGia/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Hvk_MaTG,Hvk_TenTG")] Hvk_TacGia hvk_TacGia)
        {
            if (ModelState.IsValid)
            {
                db.Hvk_TacGia.Add(hvk_TacGia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hvk_TacGia);
        }

        // GET: Hvk_TacGia/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hvk_TacGia hvk_TacGia = db.Hvk_TacGia.Find(id);
            if (hvk_TacGia == null)
            {
                return HttpNotFound();
            }
            return View(hvk_TacGia);
        }

        // POST: Hvk_TacGia/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Hvk_MaTG,Hvk_TenTG")] Hvk_TacGia hvk_TacGia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hvk_TacGia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hvk_TacGia);
        }

        // GET: Hvk_TacGia/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hvk_TacGia hvk_TacGia = db.Hvk_TacGia.Find(id);
            if (hvk_TacGia == null)
            {
                return HttpNotFound();
            }
            return View(hvk_TacGia);
        }

        // POST: Hvk_TacGia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Hvk_TacGia hvk_TacGia = db.Hvk_TacGia.Find(id);
            db.Hvk_TacGia.Remove(hvk_TacGia);
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
