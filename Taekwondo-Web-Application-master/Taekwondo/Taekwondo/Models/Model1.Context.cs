﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Taekwondo.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TaekwondoEntities : DbContext
    {
        public TaekwondoEntities()
            : base("name=TaekwondoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<classschedule> classschedules { get; set; }
        public virtual DbSet<fee> fees { get; set; }
        public virtual DbSet<inventory> inventories { get; set; }
        public virtual DbSet<order> orders { get; set; }
        public virtual DbSet<parent> parents { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<rank> ranks { get; set; }
        public virtual DbSet<studentclass> studentclasses { get; set; }
        public virtual DbSet<studentrank> studentranks { get; set; }
        public virtual DbSet<student> students { get; set; }
        public virtual DbSet<supplier> suppliers { get; set; }
        public virtual DbSet<studentfee> studentfees { get; set; }
    }
}
