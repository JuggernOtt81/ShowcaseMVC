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
        [HttpGet]
        public IActionResult FizzBuzzPage()
        {
            FizzBuzz model = new();
            
            model.FizzValue = 3;
            model.BuzzValue = 5;

            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult FizzBuzzPage(FizzBuzz fizzBuzz)
        {
            List<string> fbItems = new();

            bool fizz;
            bool buzz;

            for (int i = 1; i <= 100; i++)
            {
                fizz = (i % fizzBuzz.FizzValue == 0);
                buzz = (i % fizzBuzz.BuzzValue == 0);

                if(fizz == true && buzz == true)
                {
                    fbItems.Add("FizzBuzz");
                }
                else if (fizz == true)
                {
                    fbItems.Add("Fizz");
                }
                else if (buzz == true)
                {
                    fbItems.Add("Buzz");
                }
                else
                {
                    fbItems.Add(i.ToString());
                }
            }
            fizzBuzz.Result = fbItems;
            
            return View(fizzBuzz);
        }
        public IActionResult MortgageCalculatorPage()
        {
            Loan loan = new();

            loan.Payment = 0.00m;
            loan.TotalCost = 0.00m;
            loan.TotalInterest = 0.00m;
            loan.Rate = 0.00m;
            loan.Term = 0;
            loan.Amount = 0.00m;

            return View(loan);
        }
        //public IActionResult MortgageCalculatorPage()
        //{
        //    return View();
        //}
        //public IActionResult MortgageCalculatorPage()
        //{
        //    return View();
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
