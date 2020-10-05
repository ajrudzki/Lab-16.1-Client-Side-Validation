using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lab_16._1_Client_Side_Validation.Models;

namespace Lab_16._1_Client_Side_Validation.Controllers
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
            ViewBag.Message = "Welcome to GC Coffee";

            return View();
        }

        public IActionResult Register()
        {
            ViewBag.Register = "Please fill out the form to register!";

            return View();
        }

        public IActionResult AddUser(string firstname, string lastname, string email, string password)
        {
            ViewBag.Welcome = $"Welcome, {firstname} {lastname}!";

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
