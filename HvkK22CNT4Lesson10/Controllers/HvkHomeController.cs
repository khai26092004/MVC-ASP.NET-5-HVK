using HvkK22CNT4Lesson10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HvkK22CNT4Lesson10.Controllers
{
    public class HvkHomeController : Controller
    {
        public ActionResult HvkIndex()
        {
            // Kiểm tra dữ liệu trong session
            if (Session["HvkAccount"] != null)
            {
                var hvkAccount = Session["HvkAccount"] as HvkAccount;
                ViewBag.FullName = hvkAccount.HvkFullName;
            }
            return View();
        }

        public ActionResult HvkAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult HvkContact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}