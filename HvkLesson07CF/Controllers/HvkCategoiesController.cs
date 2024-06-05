using HvkLesson07CF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HvkLesson07CF.Controllers
{
    public class HvkCategoiesController : Controller
    {
        private static HvkBookStore hvkDb;
        public HvkCategoiesController()
        {
            hvkDb = new HvkBookStore();
        }
        // GET: HvkCategories
        public ActionResult HvkIndex()
        {
            /*
             * Khởi tạo DBcontext;
             * EF sẽ tìm thông tin kết nối trong file machinee.config của .Net Famework trên máy
             * Và sau đó tạo csdl
             * */
            var hvkCategory = hvkDb.HvkCategories.ToList();
            return View(hvkCategory);
        }
        public ActionResult HvkCreate()
        {
            var hvkCategory = new HvkCategory();
            return View(hvkCategory);
        }
        [HttpPost]
        public ActionResult hvkCreate(HvkCategory hvkCategory)
        {
            hvkDb.HvkCategories.Add(hvkCategory);
            hvkDb.SaveChanges();
            return RedirectToAction("hvkIndex");
        }
    }
}