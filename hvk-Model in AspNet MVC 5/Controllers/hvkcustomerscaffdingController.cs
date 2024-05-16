using hvk_Model_in_AspNet_MVC_5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace hvk_Model_in_AspNet_MVC_5.Controllers
{
    public class hvkcustomerscaffdingController : Controller
    {
        // mockdata 
        private static List<hvkcustomer> listcustomer = new List<hvkcustomer>()
            {
                new hvkcustomer()
            {
                CustomerID = 1,
                FirstName = "hoang van",
                LastName = "khai",
                Address = "k22cnt4",
                YearofBirth = 2004
            },
                new hvkcustomer()
                {
                    CustomerID=2,
                    FirstName="Hoàng Văn ",
                    LastName="Long",
                    Address="k22cnt4",
                    YearofBirth=2004
                },
                new hvkcustomer()
                {
                    CustomerID=3,
                    FirstName="Hoàng Văn ",
                    LastName="Khương",
                    Address="k22cnt4",
                    YearofBirth=2004
                },
                new hvkcustomer()
                {
                    CustomerID=4,
                    FirstName="Hoàng Văn ",
                    LastName="Khanh",
                    Address="k22cnt4",
                    YearofBirth=2004
                },
            };
        // GET: hvkcustomerscaffding
        // list customer 

        public ActionResult Index()
        {
            return View(listcustomer);
        }
        [HttpGet]
        public ActionResult hvkCreate()
        {
            var model = new hvkcustomer();
            return View(model);

        }
        [HttpPost]
        public ActionResult hvkCreate(hvkcustomer model)
        {
            // thêm mới đối tượng khách hàng vào danh sách dữ liệu 
            listcustomer.Add(model);

            // return View(model);
            // chuyển về danh sách 
            return RedirectToAction("Index");

        }
        public ActionResult hvkEdit(int id)
        {
            var customer = listcustomer.FirstOrDefault(x => x.CustomerID == id);
            return View(customer);
        }
    }
}