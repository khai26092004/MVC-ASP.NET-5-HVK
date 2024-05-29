using Hvk_BaiThiGiuaKi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Hvk_BaiThiGiuaKi.Controllers
{
    public class HvkCustomerController : Controller
    {
        // Danh sách tĩnh của khách hàng
        private static List<HvkCustomer> hvkcustomer = new List<HvkCustomer>()
        {
            new HvkCustomer() {_2210900109_CustId = "2210900109", Hvk_FullName = "Hoàng Văn Khải", Hvk_Address = "Hà Nội", Hvk_Email = "khai1356682@gmail.com", Hvk_Balance = 1000, Hvk_Phone = "0866983529"},
            new HvkCustomer() {_2210900109_CustId = "224332", Hvk_FullName = "Hoàng Văn Long", Hvk_Address = "Hà Nội", Hvk_Email = "long1356682@gmail.com", Hvk_Balance = 1000, Hvk_Phone = "0866983529"},
            new HvkCustomer() {_2210900109_CustId = "2210900", Hvk_FullName = "Hoàng Văn Đức", Hvk_Address = "Hà Nội", Hvk_Email = "duc1356682@gmail.com", Hvk_Balance = 1000, Hvk_Phone = "0866983529"},
            new HvkCustomer() {_2210900109_CustId = "221090", Hvk_FullName = "Hoàng Văn Định", Hvk_Address = "Hà Nội", Hvk_Email = "dinh1356682@gmail.com", Hvk_Balance = 1000, Hvk_Phone = "0866983529"},
            new HvkCustomer() {_2210900109_CustId = "221091", Hvk_FullName = "Hoàng Văn Kiên", Hvk_Address = "Hà Nội", Hvk_Email = "kien1356682@gmail.com", Hvk_Balance = 1000, Hvk_Phone = "0866983529"}
        };

        // GET: HvkCustomer
        public ActionResult HvkIndex()
        {
            return View(hvkcustomer);
        }

        public ActionResult HvkCreate()
        {
            return View();
        }

        // POST: /Customer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult HvkCreate(HvkCustomer cus)
        {
            if (ModelState.IsValid)
            {
                hvkcustomer.Add(cus);
                return RedirectToAction("HvkIndex");
            }
            return View(cus);
        }

        public ActionResult HvkEdit(string hvkid)
        {
            var customer_hvk = hvkcustomer.FirstOrDefault(x => x._2210900109_CustId == hvkid);
            if (customer_hvk == null)
            {
                return HttpNotFound();
            }
            return View(customer_hvk);
        }

        // POST: /Customer/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult HvkEdit(HvkCustomer cus)
        {
            if (ModelState.IsValid)
            {
                var existingCustomer = hvkcustomer.FirstOrDefault(x => x._2210900109_CustId == cus._2210900109_CustId);
                if (existingCustomer != null)
                {
                    existingCustomer.Hvk_FullName = cus.Hvk_FullName;
                    existingCustomer.Hvk_Address = cus.Hvk_Address;
                    existingCustomer.Hvk_Email = cus.Hvk_Email;
                    existingCustomer.Hvk_Phone = cus.Hvk_Phone;
                    existingCustomer.Hvk_Balance = cus.Hvk_Balance;
                }
                return RedirectToAction("HvkIndex");
            }
            return View(cus);
        }
        public ActionResult Hvkdetails(string hvkid)
        {
            var customer_hvk = hvkcustomer.FirstOrDefault()
        }
    }
}
