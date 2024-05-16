using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hvk_Model_in_AspNet_MVC_5.Models
{
    public class hvkcustomer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int YearofBirth { get; set; }
    }
}