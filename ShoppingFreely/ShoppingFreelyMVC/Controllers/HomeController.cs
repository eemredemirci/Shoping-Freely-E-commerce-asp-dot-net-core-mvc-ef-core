using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShoppingFreelyMVC.Data;
using ShoppingFreelyMVC.Models;
using System.Diagnostics;

namespace ShoppingFreelyMVC.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(/*ILogger<HomeController> logger ,*/ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IActionResult> Index()
        {
            if (currentList != null)
            {
                ViewData["ListName"] = currentList.Name +" Listesi Seçildi";
            }
            var applicationDbContext = _context.Products.Include(p => p.Category);
            return View(await applicationDbContext.ToListAsync());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // return listeye ekleyen kişi popup
        public string GetData()
        {
            return "John Nash";
        }
    }
}