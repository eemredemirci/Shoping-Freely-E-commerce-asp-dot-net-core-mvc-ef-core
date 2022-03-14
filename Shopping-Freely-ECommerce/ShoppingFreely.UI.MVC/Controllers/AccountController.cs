using Microsoft.AspNetCore.Mvc;
using ShoppingFreely.UI.MVC.Models;

namespace ShoppingFreely.UI.MVC.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login(string? ReturnUrl)
        {
            return View(ReturnUrl);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model, string? ReturnUrl)
        {
            if (ModelState.IsValid)
            {
                if (model.Email == "admin" && model.Password == "123")
                {

                }
                else
                {
                    ModelState.AddModelError("", "Kullanıcı bilgileri hatalı");
                    return View(model);
                }
            }
            return Redirect(nameof(HomeController.Index));
        }
    }
}
