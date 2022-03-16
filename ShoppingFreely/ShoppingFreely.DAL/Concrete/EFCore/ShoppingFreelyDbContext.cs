using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShoppingFreely.DAL.Concrete.EFCore.Mapping;
using ShoppingFreely.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingFreely.DAL.Concrete
{
    internal class ShoppingFreelyDbContext: IdentityDbContext
    {
        public ShoppingFreelyDbContext()
        {

        }
        public ShoppingFreelyDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<User> Users{ get; set; }
        public DbSet<Product> Products{ get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<List> Lists { get; set; }
        public DbSet<ListProductDetail> ListProductDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new UserMapping());
            //modelBuilder.ApplyConfiguration(new TaskMapping());

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = ShoppingFreely;");
            }
        }
    }
}
