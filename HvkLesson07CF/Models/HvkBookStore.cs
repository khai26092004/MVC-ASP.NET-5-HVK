using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HvkLesson07CF.Models
{
    public class HvkBookStore:DbContext
    {
        public HvkBookStore() { }   
        // Khai các thuộc tính tương ứng với các bảng trong CSDl
        public DbSet<HvkCategory> HvkCategories { get; set; }
        public DbSet<Hvkbook>   Hvkbooks { get; set; }  
    }
}