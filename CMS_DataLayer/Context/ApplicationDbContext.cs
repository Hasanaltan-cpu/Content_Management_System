using CMS_DataLayer.SeedData;
using Cms_EntityLayer.Entities.Concrete;
using CMS_MapLayer.Mapping.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS_DataLayer.Context
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options){}


        public DbSet<Category> Categories { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CategoryMap());
            builder.ApplyConfiguration(new AppUserMap());
            builder.ApplyConfiguration(new PageMap());
            builder.ApplyConfiguration(new ProductMap());
            builder.ApplyConfiguration(new SeedPages());
            base.OnModelCreating(builder);

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

    }
}
