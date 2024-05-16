using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hvk_lab04_2.Models;
using static Hvk_lab04_2.Controllers.HvkCustomerController;
namespace Hvk_lab04_2.Controllers
{
    public class HvkCustomerController : Controller
    {
        //khai báo biến CustomerRepository
        static CustomerRepository listCustomer;
        public HvkCustomerController()
        {
            //khởi tạo CustomerRepository
            listCustomer = new CustomerRepository();
        }
        // GET: /Customer/GetCustomers
        public ActionResult HvkGetCustomers()
        {
            return View(listCustomer.GetCustomers());
        }
        //POST: /Customer/GetCustomers
        [HttpPost]
        public ActionResult HvkGetCustomers(string name)
        {
            return View(listCustomer.SearchCustomer(name));
        }
        // GET: /Customer/Details/5
        public ActionResult HvkDetails(string id)
        {
            return View(listCustomer.GetCustomer(id));
        }
        // GET: /Customer/Create
        public ActionResult HvkCreate()
        {
            return View();
        }
        // POST: /Customer/Create
        [HttpPost]
        public ActionResult HvkCreate(HvkCustomer cus)
        {
            listCustomer.AddCustomer(cus);
            return RedirectToAction("HvkGetCustomers");
        }
        // GET: /Customer/Edit/5
        public ActionResult HvkEdit(string id)
        {
            return View(listCustomer.GetCustomer(id));
        }
        // POST: /Customer/Edit
        [HttpPost]
        public ActionResult HvkEdit(HvkCustomer cus)
        {
            listCustomer.UpdateCustomer(cus);
            return RedirectToAction("HvkGetCustomers");
        }
        // GET: /Customer/Delete/5
        public ActionResult HvkDelete(string id)
        {
            listCustomer.DeleteCustomer(listCustomer.GetCustomer(id));
            return RedirectToAction("HvkGetCustomers");
        }
    }
}