using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HvkK22CNT4Lesson10.Models;

namespace HvkK22CNT4Lesson10.Controllers
{
    public class HvkAccountsController : Controller
    {
        private HvkK22CNT4Lesson10DbEntities db = new HvkK22CNT4Lesson10DbEntities();

        // GET: HvkAccounts
        public ActionResult Index()
        {
            return View(db.HvkAccount.ToList());
        }

        // GET: HvkAccounts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HvkAccount hvkAccount = db.HvkAccount.Find(id);
            if (hvkAccount == null)
            {
                return HttpNotFound();
            }
            return View(hvkAccount);
        }

        // GET: HvkAccounts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HvkAccounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HvkID,HvkUserName,HvKPassword,HvkFullName,HvkEmail,HvkPhone,HvkAtive")] HvkAccount hvkAccount)
        {
            if (ModelState.IsValid)
            {
                db.HvkAccount.Add(hvkAccount);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hvkAccount);
        }

        // GET: HvkAccounts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HvkAccount hvkAccount = db.HvkAccount.Find(id);
            if (hvkAccount == null)
            {
                return HttpNotFound();
            }
            return View(hvkAccount);
        }

        // POST: HvkAccounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HvkID,HvkUserName,HvKPassword,HvkFullName,HvkEmail,HvkPhone,HvkAtive")] HvkAccount hvkAccount)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hvkAccount).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hvkAccount);
        }

        // GET: HvkAccounts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HvkAccount hvkAccount = db.HvkAccount.Find(id);
            if (hvkAccount == null)
            {
                return HttpNotFound();
            }
            return View(hvkAccount);
        }

        // POST: HvkAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HvkAccount hvkAccount = db.HvkAccount.Find(id);
            db.HvkAccount.Remove(hvkAccount);
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
        // Login
        public ActionResult HvkLogin()
        { 
            var hvkModel = new HvkAccount();
            return View(hvkModel); 
        }
        [HttpPost]
        public ActionResult HvkLogin(HvkAccount hvkAccount)
        {
            var hvkCheck = db.HvkAccount.Where(x => x.HvkUserName.Equals(hvkAccount.HvkUserName) && x.HvKPassword.Equals(hvkAccount.HvKPassword)).FirstOrDefault();
            if (hvkCheck != null) 
            {
                // Lưu session
                Session["HvkAccount"] = hvkCheck;
                return Redirect("/");
            }
            return View(hvkAccount);
        }


    }
}
