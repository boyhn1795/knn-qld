﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyDiem
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLDEntities : DbContext
    {
        public QLDEntities()
            : base("name=QLDEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tblKhoa> tblKhoas { get; set; }
        public virtual DbSet<tblMonHoc> tblMonHocs { get; set; }
        public virtual DbSet<tblSinhVien> tblSinhViens { get; set; }
        public virtual DbSet<tblDiem> tblDiems { get; set; }
    }
}