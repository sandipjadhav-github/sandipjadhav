﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ContactInfoManagement.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ContactInformationEntities : DbContext
    {
        public ContactInformationEntities()
            : base("name=ContactInformationEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ContactType> ContactTypes { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<PersonContact> PersonContacts { get; set; }
    }
}
