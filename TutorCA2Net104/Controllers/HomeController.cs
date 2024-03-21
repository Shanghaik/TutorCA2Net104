using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TutorCA2Net104.Models;

namespace TutorCA2Net104.Controllers
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
            return View();
        }

    }
        
}