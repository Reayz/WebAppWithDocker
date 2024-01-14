﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppWithDocker2.Models;

namespace WebAppWithDocker2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            var developerName = _configuration.GetValue<string>("DeveloperName");
            var universityName = _configuration.GetValue<string>("DeveloperInfo:UniversityName");
            ViewData["DeveloperName"] = developerName;
            ViewData["UniversityName"] = universityName;
            _logger.LogInformation($"This action executed at {DateTime.UtcNow}");
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