using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab05.Models;


namespace lab05.Controllers
{
    public class HvkMemberController : Controller
    {
        // GET: HvkMember/HvkCreateOne
        public ActionResult HvkCreateOne()
        {
            return View();
        }
        //POST: HvkMember/HvkCreateOne
        [HttpPost]
        public ActionResult HvkCreateOne(HvkMember m)
        {
            return View("HvkDetails", m);
        }
        // GET: HvkMember/HvkCreateTwo
        public ActionResult HvkCreateTwo()
        {
            return View();
        }
        //POST: HvkMember/HvkCreateTwo
        [HttpPost]
        public ActionResult HvkCreateTwo(HvkMember m)
        {
            if (m.Id == null)
            {
                ViewBag.error = "Hãy nhập mã số";
                return View();
            }
            if (m.HvkUsername == null)
            {
                ViewBag.error = "Hãy nhập tên đăng nhập";
                return View();
            }
            if (m.HvkFullName == null)
            {
                ViewBag.error = "Hãy nhập họ và tên";
                return View();
            }
            if (m.HvkAge == null)
            {
                ViewBag.error = "Hãy nhập tuổi";
                return View();
            }
            if (m.HvkEmail == null)
            {
                ViewBag.error = "Hãy nhập email";
                return View();
            }
            string HvkregePattern = @"[A-Za - z0-9._%+-] + @[A-Za - z0-9.-]+\.[A-Za - z] {2 - 4}";
            if (System.Text.RegularExpressions.Regex.IsMatch(m.HvkEmail, HvkregePattern))
            {
                ViewBag.error = "Hãy nhập đúng định dạng";
                return View();
            }
            return View("HvkDetails", m);
        }
        // GET: HvkMember/HvkCreateThree
        public ActionResult HvkCreateThree()
        {
            return View();
        }
        //POST: HvkMember/HvkCreateThree
        [HttpPost]
        public ActionResult HvkCreateThree(HvkMember m)
        {
            if (!ModelState.IsValid)
            {
                return View("HvkDetails", m);
            }
            else
            {
                return View();
            }
        }
        public ActionResult HvkDetails()
        {
            return View();
        }
    }
}