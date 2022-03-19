using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShoppingFreelyMVC.Data;
using ShoppingFreelyMVC.Models;
using ShoppingFreelyMVC.Models.Authentication;


namespace ShoppingFreelyMVC.Controllers
{
    public class BaseController : Controller
    {
        protected readonly UserManager<User> userManager;
        protected readonly RoleManager<IdentityRole> roleManager;
        protected readonly SignInManager<User> signInManager;
        protected readonly ApplicationDbContext _context;
        protected ShoppingList currentList;
        public BaseController(ApplicationDbContext context, UserManager<User> userManager, SignInManager<User> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.signInManager = signInManager;
        }
        public BaseController(ApplicationDbContext context, UserManager<User> userManager)
        {
            _context = context;
            this.userManager = userManager;
        }
        public string GetCurrentUserIdAsync() => userManager.GetUserId(User);
        public ShoppingList GetCurrentShoppingList(ShoppingList shoppingList) => currentList = shoppingList;
    }
}
