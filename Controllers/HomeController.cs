using Blockchat.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Blockchat.Controllers
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

        public IActionResult Privacy()
        {
            return View("WebRTC");
        }

        public IActionResult WebRTC()
        {
            return View("WebRTC");
        }

        public IActionResult Store()
        {
            return View();
        }
        public IActionResult Promote()
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