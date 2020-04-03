﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication25.Models;

namespace WebApplication25.Controllers
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


        
        public IActionResult empdetails()

        {
            ViewData["info"] = "employee info";
            ViewBag.details = "it shows a list of employee";
            List<emp> obj = new List<emp>()
            {
                new emp{ eid=1,ename="deba",edesig="it"}
            };
            return View(obj);
        }

        public IActionResult empdat()
        {
            ViewData["empdata"] = "emps";

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
