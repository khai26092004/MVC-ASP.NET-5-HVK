using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HvkLesson07Db.Models;

namespace HvkLesson07Db.Controllers
{
    public class hvkKhoasController : Controller
    {
        private HvkK22CNT4Lesson07DbEntities db = new HvkK22CNT4Lesson07DbEntities();

        // GET: hvkKhoas
        public ActionResult HvkIndex()
        {
            return View(db.hvkKhoa.ToList());
        }

        // GET: hvkKhoas/Details/5
        public ActionResult HvkDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hvkKhoa hvkKhoa = db.hvkKhoa.Find(id);
            if (hvkKhoa == null)
            {
                return HttpNotFound();
            }
            return View(hvkKhoa);
        }

        // GET: hvkKhoas/Create
        public ActionResult HvkCreate()
        {
            return View();
        }

        // POST: hvkKhoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult HvkCreate([Bind(Include = "HvkKH,HvkTenKH,HvkTrangThai")] hvkKhoa hvkKhoa)
        {
            if (ModelState.IsValid)
            {
                db.hvkKhoa.Add(hvkKhoa);
                db.SaveChanges();
                return RedirectToAction("HvkIndex");
            }

            return View(hvkKhoa);
        }

        // GET: hvkKhoas/Edit/5
        public ActionResult HvkEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hvkKhoa hvkKhoa = db.hvkKhoa.Find(id);
            if (hvkKhoa == null)
            {
                return HttpNotFound();
            }
            return View(hvkKhoa);
        }

        // POST: hvkKhoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult HvkEdit([Bind(Include = "HvkKH,HvkTenKH,HvkTrangThai")] hvkKhoa hvkKhoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hvkKhoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("HvkIndex");
            }
            return View(hvkKhoa);
        }

        // GET: hvkKhoas/Delete/5
        public ActionResult HvkDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hvkKhoa hvkKhoa = db.hvkKhoa.Find(id);
            if (hvkKhoa == null)
            {
                return HttpNotFound();
            }
            return View(hvkKhoa);
        }

        // POST: hvkKhoas/Delete/5
        [HttpPost, ActionName("HvkDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            hvkKhoa hvkKhoa = db.hvkKhoa.Find(id);
            db.hvkKhoa.Remove(hvkKhoa);
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
