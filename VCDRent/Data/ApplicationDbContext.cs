using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VCDRent.Models;
using VCDRent.Models.Invent;

namespace VCDRent.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            /*****************************************************************************
            *  Identifikasi Primary Key
            *****************************************************************************/
            builder.Entity<TMember>().HasKey(e => new { e.memberID });
            builder.Entity<TKnowThis>().HasKey(e => new { e.knowthisID });
            builder.Entity<TPackage>().HasKey(e => new { e.packageID });
            builder.Entity<TConfirmContact>().HasKey(e => new { e.confirmcontactID });
            builder.Entity<TMemberConfirmContact>().HasKey(e => new { e.confirmcontactID, e.memberID });
            /*****************************************************************************
            *  Copyright (c) SDY_RI, 2018
            *  
            *  This file is part of VCDRent
            *****************************************************************************/
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<ApplicationRole> ApplicationRole { get; set; }
        public DbSet<TMember> TMember { get; set; }
        public DbSet<TKnowThis> TKnowThis { get; set; }
        public DbSet<TPackage> TPackage { get; set; }
        public DbSet<TConfirmContact> TConfirmContact { get; set; }
        public DbSet<TMemberConfirmContact> TMemberConfirmContact { get; set; }
    }
}
