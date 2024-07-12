using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HvkK22CNT4Lesson12_2210900109
{
    public class HvkHomeController : Controller
    {
        public ActionResult HvkIndex()
        {
            return View();
        }

        public ActionResult HvkAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult HvkContact()
        {
            ViewBag.Msv = "2210900109";
            ViewBag.FullName = "Hoàng Văn Khải";

            return View();
        }
    }
}