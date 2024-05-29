using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HvkLab04.Models;

namespace Dtl_lab04.Controllers
{
    public class HvkCustomerController : Controller
    {
        // GET: /Customer/CustomerDetail (action trả về thông tin chi tiết 1 khách hàng cho view HVkCustomerDetail
        public ActionResult HvkCustomerDetail()
        {
            //tạo một đối tượng Customer ( nhớ using Lab04.Models)
            Hvkcustomer customer = new Hvkcustomer()
            {
                CustomerId = "2210900109",
                FullName = "Hoàng Văn Khải",
                Email = "Khai135668@gmail.com",
                Address = "k22Cnt4",
                Phone = "0866988833",
                Balance = 152000
            };
            return View(customer);
        }
        public ActionResult HvkCustomerList()
        {
            //tạo một danh sách khách hàng
            List<Hvkcustomer> listcustomer = new List<Hvkcustomer>(){
                new Hvkcustomer(){ CustomerId = "KH001",
                FullName = "Trịnh Văn Chung",
                Address = "Hà Nội",Email = "devmaster.founder@gmail.com",
                Phone = "0978.611.889",Balance = 15200000},
                new Hvkcustomer(){ CustomerId = "KH002", FullName = "Đỗ Thị Cúc",
                Address = "Hà Nội",Email = "cucdt@gmail.com",
                Phone = "0986.767.444",Balance = 2200000},
                new Hvkcustomer(){ CustomerId = "KH003",
                FullName = "Nguyễn Tuấn Thắng",
                Address = "Nam Định",Email = "thangnt@gmail.com",
                Phone = "0924.656.542",Balance = 1200000},
                new Hvkcustomer(){ CustomerId = "KH004", FullName = "Lê Ngọc Hải",
                Address = "Hà Nội",Email = "hailn@gmail.com",
                Phone = "0996.555.267",Balance = 6200000 }
};
            //gán dữ liệu vào ViewBag để chuyển qua View
            ViewBag.listcustomer = listcustomer;
            return View();
        }

    }
}