using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserCrudAPI.BL
{
    public class MyDbContext : DbContext 
    {
        public DbSet<IdentityUser> IdentityUsers { get; set; }
        public DbSet<IdentityRole> IdentityRoles { get; set; }
        //public DbSet<IdentityUserClaim<>> IdentityUserClaims { get; set; }

        public MyDbContext() { }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\ProjectsV13;Database=MyDb;Trusted_Connection=True;");
        }
    }
}
