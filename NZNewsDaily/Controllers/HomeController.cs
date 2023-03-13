using Microsoft.AspNetCore.Mvc;
using NZNewsDaily.Models;
using System.Diagnostics;

namespace NZNewsDaily.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NewZealand()
        {
            return View();
        }

        public IActionResult Technology()
        {
            return View();
        }

        public IActionResult Sports()
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