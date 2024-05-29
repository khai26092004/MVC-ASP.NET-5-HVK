using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hvk_BaiThiGiuaKi.Models
{
    public class HvkCustomer
    {
        public string _2210900109_CustId { get; set; }
        public string Hvk_FullName { get; set; }
        public string Hvk_Address { get; set; }
        public string Hvk_Email { get; set; }
        public string Hvk_Phone { get; set; }
        public int Hvk_Balance { get; set; }
    }
}