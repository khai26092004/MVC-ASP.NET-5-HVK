using hvk_Model_in_AspNet_MVC_5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hvk_Model_in_AspNet_MVC_5.Controllers
{
    public class hvkcustomerController : Controller
    {
        // GET: hvkcustomer
        public ActionResult Index()
        {
            return View();
        }
        /// action: hvk customer detail
        public ActionResult hvkcustomerDetail() 
        {
            // tao doi tuong du lieu 
            var customer = new hvkcustomer()
            {
                CustomerID = 1,
                FirstName = "hoang van",
                LastName = "khai",
                Address = "k22cnt4",
                YearofBirth = 2004
            };
            ViewBag.customer = customer;
            return View(0);

        }
        // Get: HvkListCustomer
        public ActionResult hvklistcustomer() 
        {
            var list = new List<hvkcustomer>()
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
            ViewBag.list = list; // đưa dữ liệu ra view bằng đối tượng viewbag 
            return View(0);
        }
    }
}