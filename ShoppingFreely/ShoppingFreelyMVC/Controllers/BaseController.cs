using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShoppingFreelyMVC.Data;
using ShoppingFreelyMVC.Models;
using ShoppingFreelyMVC.Models.Authentication;


namespace ShoppingFreelyMVC.Controllers
{
    public class BaseController : Controller
    {
        protected readonly UserManager<User>? _userManager;
        protected readonly RoleManager<IdentityRole> _roleManager;
        protected readonly SignInManager<User> _signInManager;
        protected readonly ApplicationDbContext _context;
        public static ShoppingList currentList;
        public BaseController(ApplicationDbContext context, UserManager<User> userManager, SignInManager<User> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }
        public BaseController(ApplicationDbContext context, UserManager<User> userManager)
        {
            _context = context;
            this._userManager = userManager;
        }
        public BaseController(ApplicationDbContext context)
        {
            _context = context;
        }
        public string GetCurrentUserIdAsync() => _userManager.GetUserId(User);
        public async Task<User> GetCurrentUser()
        {
            User user = await _userManager.FindByIdAsync(_userManager.GetUserId(User));
            return user;
        }

        public ShoppingList GetCurrentShoppingList(ShoppingList shoppingList) => currentList = shoppingList;
    }
}
