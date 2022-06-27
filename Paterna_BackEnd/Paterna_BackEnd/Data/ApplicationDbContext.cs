using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Paterna_BackEnd.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paterna_BackEnd.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        private readonly DbContextOptions _options;
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            _options = options;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
        public DbSet<Services> Services { get; set; }
        //public DbSet<Setting> Settings { get; set; }

    }
}
