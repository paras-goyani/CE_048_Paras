using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc_demo.Models;


namespace mvc_demo.Controllers
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

       
        public IActionResult test1()
        {
            int a = 30, b = 20;

            ViewBag.a = a;
            ViewBag.b = b;
            ViewBag.answer =a+b ;
            return View();
        }

        [HttpGet]
        public IActionResult test2()
        {
            return View();
        }

        [HttpPost]
        public IActionResult test2(string num1, string num2)
        {
            int ans = Int32.Parse(num1) + Int32.Parse(num2);
            ViewBag.a = num1;
            ViewBag.b = num2;
            ViewBag.answer = ans;
            return View();
        }

        public IActionResult user_Registration()
        {
            return View();
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
