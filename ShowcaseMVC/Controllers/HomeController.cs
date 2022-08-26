using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShowcaseMVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ShowcaseMVC.Controllers
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
        public IActionResult MinorProjectsPage()
        {
            return View();
        }
        public IActionResult MediumProjectsPage()
        {
            return View();
        }
        public IActionResult MajorProjectsPage()
        {
            return View();
        }
        public IActionResult OpenSourceProjectsPage()
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
