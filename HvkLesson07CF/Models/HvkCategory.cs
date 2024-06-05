
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HvkLesson07CF.Models
{
    public class HvkCategory
    {
        [Key]
        public int HvkId { get; set; }
        public string HvkCategoryName { get; set; }

        // thuộc tính quan hệ 
        public virtual ICollection<Hvkbook> HvkBooks { get; set; }
    }
}