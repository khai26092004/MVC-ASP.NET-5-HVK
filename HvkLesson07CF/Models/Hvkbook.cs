using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HvkLesson07CF.Models
{
    public class Hvkbook
    {
        [Key]
        public int HvkId { get; set; }
        public string HvkBookId {  get; set; }
        public string HvkTitle { get; set; }
        public string HvkAuthor { get; set; }   
        public int HvkYear { get; set; }    
        public string HvkPulisher { get; set;}
        public string HvkPicture { get; set; }
        public int HvkCategoryId {get; set;}    
        // thuộc tính quan hệ 
        public virtual HvkCategory HvkCategory { get; set; }   
    }
}