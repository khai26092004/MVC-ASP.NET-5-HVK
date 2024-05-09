using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hvk_LessonOnline2._3._4.Controllers
{
    /// <summary>
    /// Author: Hoang Van Khai
    /// Class: cnt4
    /// </summary>
    public class HvkstudentController : Controller
    {
        // GET: Hvkstudent
        public ActionResult Index()
        {
            // truyen du lieu tu controller -> view 
            ViewBag.fullname = "Hoang Van Khai ";
            ViewData["Birtday"] = "26 / 9 / 2004";
            TempData["Phone"] = "0866983269";
            return View();
        }

        public ActionResult Details()
        {
            string hvkstr = "";
            hvkstr += "<h3> Họ và tên: Hoàng Văn Khải </h3>";
            hvkstr += "<p> Mã Số: 2210900109 </p>";
            hvkstr += "<p> Địa chỉ Email: HoangVanKhai@gmail.com </p>";
            ViewBag.Details = hvkstr;
            return View("chitiet");
        }
        public ActionResult NgonnguRazor()
        {
            string[] names = { "Hoang Van A", "Nguyen Van B", "Trinh Thanh K" };
            ViewBag.names = names;
            return View();
        }
        //HTML Helper
        //Get:hvkstudent/addnewStudent
        public ActionResult AddnewStudent()
        { return View(); 
        }
        [HttpPost]
        public ActionResult AddnewStudent(FormCollection form)
        {
            // lay du lieu tren form
            string fullname = form["fullname"];
            string masosv = form["masosv"];
            string taikhoan = form["taikhoan"];
            string matkhau = form["matkhau"];

            string hvkstr = "<h3>" + fullname + "<h3/>";
            hvkstr += "<p>" + masosv;
            hvkstr += "<p>" + taikhoan;
            hvkstr += "<p>" + matkhau;
              
            ViewBag.info = hvkstr;
            return View("ketqua");
        }
    }

}