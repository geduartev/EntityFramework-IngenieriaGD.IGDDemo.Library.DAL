﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoEF.Backend.Business.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ZuluSoftwareEntities : DbContext
    {
        public ZuluSoftwareEntities()
            : base("name=ZuluSoftwareEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<EPM_Clients> EPM_Clients { get; set; }
        public virtual DbSet<EPM_Deliveries> EPM_Deliveries { get; set; }
    }
}