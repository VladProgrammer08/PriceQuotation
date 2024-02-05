using Microsoft.AspNetCore.Mvc;
using PriceQuotation.Models;
using System.Diagnostics;

namespace PriceQuotation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            PriceQuote quote = new PriceQuote();
            return View(quote);
        }

        [HttpPost]
        public IActionResult Index(PriceQuote quote)
        {
            if (ModelState.IsValid)
            {
                // Return model with the result calculated
                return View(quote);
            }
            // Return the model with the error messages
            return View(quote);
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
    }
}
