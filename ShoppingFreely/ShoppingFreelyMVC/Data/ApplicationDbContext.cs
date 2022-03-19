using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppingFreelyMVC.Models;
using ShoppingFreelyMVC.Models.Authentication;
using System.Reflection;

namespace ShoppingFreelyMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingList> ShoppingLists { get; set; }
        public DbSet<ShopingListDetail> ShopingListDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Db Modelleri oluşturduktan sonra admin User ekle
            // Çalışmıyor Hatası
            // "The INSERT statement conflicted with the FOREIGN KEY constraint "FK_AspNetUserRoles_AspNetUsers_UserId".
            // The conflict occurred in database "aspnet-ShoppingFreelyMVC-3C90114D-4E4D-466B-9B6F-CB581A88257B", table "dbo.AspNetUsers", column 'Id'."

            //// any unique string id
            //const string ADMIN_ID = "0";
            //const string ROLE_ID = "1";

            //builder.Entity<IdentityRole>().HasData(new IdentityRole
            //{
            //    Id = ROLE_ID,
            //    Name = "admin",
            //    NormalizedName = "admin"
            //});

            //var hasher = new PasswordHasher<IdentityUser>();
            //builder.Entity<IdentityUser>().HasData(new IdentityUser
            //{
            //    Id = ADMIN_ID,
            //    UserName = "admin",
            //    NormalizedUserName = "admin",
            //    Email = "admin@mail.com",
            //    NormalizedEmail = "admin@mail.com",
            //    EmailConfirmed = true,
            //    PasswordHash = hasher.HashPassword(null, "Emre123."),
            //    SecurityStamp = string.Empty
            //});

            //builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            //{
            //    RoleId = ROLE_ID,
            //    UserId = ADMIN_ID
            //});


        }
    }

}
