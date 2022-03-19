using Microsoft.AspNetCore.Identity;
using ShoppingFreelyMVC.Models.Authentication;

namespace ShoppingFreelyMVC.Data
{
    public class AdminInitializer
    {
        public static void SeedData(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);
        }
        public static void SeedUsers(UserManager<User> userManager)
        {
            if (userManager.FindByNameAsync("admin").Result == null)
            {
                User user = new User();
                user.UserName = "admin";
                user.Email = "admin@shoppingfreely.com";

                IdentityResult result = userManager.CreateAsync(user, "Emre123.").Result;
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Administrator").Wait();
                }
            }
        }

        public static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("Administrator").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Administrator";
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }
        }
    }
}
