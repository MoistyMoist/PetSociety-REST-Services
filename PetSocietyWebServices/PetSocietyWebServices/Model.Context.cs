﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PetSocietyWebServices
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PetSocietyDBEntities : DbContext
    {
        public PetSocietyDBEntities()
            : base("name=PetSocietyDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ADVERT> ADVERTs { get; set; }
        public DbSet<ATTENDEE> ATTENDEEs { get; set; }
        public DbSet<EVENT> EVENTs { get; set; }
        public DbSet<FRIEND_LIST> FRIEND_LIST { get; set; }
        public DbSet<FRIEND_REQUEST> FRIEND_REQUEST { get; set; }
        public DbSet<GALLERY> GALLERies { get; set; }
        public DbSet<IMAGE> IMAGEs { get; set; }
        public DbSet<LOCATION> LOCATIONs { get; set; }
        public DbSet<LOST> LOSTs { get; set; }
        public DbSet<ORGANIZATION> ORGANIZATIONs { get; set; }
        public DbSet<PET> PETs { get; set; }
        public DbSet<REVIEW> REVIEWs { get; set; }
        public DbSet<STRAY> STRAYs { get; set; }
        public DbSet<USER> USERs { get; set; }
    }
}
