using System;
using System.Collections.Generic;
using System.Text;
using crudwithidentity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace crudwithidentity.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Movie> Movie { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
            base.OnModelCreating(modelBuilder);
        }
    }
}
