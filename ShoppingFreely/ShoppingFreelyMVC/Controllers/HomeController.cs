using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShoppingFreelyMVC.Data;
using ShoppingFreelyMVC.Models;
using System.Diagnostics;

namespace ShoppingFreelyMVC.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        public HomeController(/*ILogger<HomeController> logger ,*/ApplicationDbContext context)
        {
            //_logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
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

        // return ekleyen kişi
        public string GetData()
        {
            return "John Nash";
        }
    }
}