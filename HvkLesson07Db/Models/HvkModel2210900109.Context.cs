﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HvkLesson07Db.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HvkK22CNT4Lesson07DbEntities : DbContext
    {
        public HvkK22CNT4Lesson07DbEntities()
            : base("name=HvkK22CNT4Lesson07DbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<hvkKhoa> hvkKhoa { get; set; }
        public virtual DbSet<hvkSinhVien> hvkSinhVien { get; set; }
    }
}