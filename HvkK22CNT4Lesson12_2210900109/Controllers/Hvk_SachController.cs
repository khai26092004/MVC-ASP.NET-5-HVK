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
    public class Hvk_SachController : Controller
    {
        private HoangVanKhai_2210900109Entities db = new HoangVanKhai_2210900109Entities();

        // GET: Hvk_Sach
        public ActionResult HvkIndex()
        {
            var hvk_Sach = db.Hvk_Sach.Include(h => h.Hvk_TacGia);
            return View(hvk_Sach.ToList());
        }

        // GET: Hvk_Sach/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hvk_Sach hvk_Sach = db.Hvk_Sach.Find(id);
            if (hvk_Sach == null)
            {
                return HttpNotFound();
            }
            return View(hvk_Sach);
        }

        // GET: Hvk_Sach/Create
        public ActionResult Create()
        {
            ViewBag.Hvk_MaTG = new SelectList(db.Hvk_TacGia, "Hvk_MaTG", "Hvk_TenTG");
            return View();
        }

        // POST: Hvk_Sach/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Hvk_MaSach,Hvk_TenSach,Hvk_SoTrang,Hvk_NamXB,Hvk_MaTG,Hvk_TrangThai")] Hvk_Sach hvk_Sach)
        {
            if (ModelState.IsValid)
            {
                db.Hvk_Sach.Add(hvk_Sach);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Hvk_MaTG = new SelectList(db.Hvk_TacGia, "Hvk_MaTG", "Hvk_TenTG", hvk_Sach.Hvk_MaTG);
            return View(hvk_Sach);
        }

        // GET: Hvk_Sach/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hvk_Sach hvk_Sach = db.Hvk_Sach.Find(id);
            if (hvk_Sach == null)
            {
                return HttpNotFound();
            }
            ViewBag.Hvk_MaTG = new SelectList(db.Hvk_TacGia, "Hvk_MaTG", "Hvk_TenTG", hvk_Sach.Hvk_MaTG);
            return View(hvk_Sach);
        }

        // POST: Hvk_Sach/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Hvk_MaSach,Hvk_TenSach,Hvk_SoTrang,Hvk_NamXB,Hvk_MaTG,Hvk_TrangThai")] Hvk_Sach hvk_Sach)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hvk_Sach).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Hvk_MaTG = new SelectList(db.Hvk_TacGia, "Hvk_MaTG", "Hvk_TenTG", hvk_Sach.Hvk_MaTG);
            return View(hvk_Sach);
        }

        // GET: Hvk_Sach/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hvk_Sach hvk_Sach = db.Hvk_Sach.Find(id);
            if (hvk_Sach == null)
            {
                return HttpNotFound();
            }
            return View(hvk_Sach);
        }

        // POST: Hvk_Sach/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Hvk_Sach hvk_Sach = db.Hvk_Sach.Find(id);
            db.Hvk_Sach.Remove(hvk_Sach);
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
