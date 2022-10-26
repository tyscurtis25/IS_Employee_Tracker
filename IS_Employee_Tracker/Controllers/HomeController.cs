using IS_Employee_Tracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IS_Employee_Tracker.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private EmployeeTrackerContext _empContext { get; set; }

        public HomeController(ILogger<HomeController> logger, EmployeeTrackerContext context)
        {
            _logger = logger;
            _empContext = context;
        }

        // This is our Dashboard page
        public IActionResult Index()
        {
            return View();
        }

        // This is where you input new records
        public IActionResult Form()
        {
            return View();
        }

        // This displays a table that you can filter
        public IActionResult Display()
        {
            return View();
        }

        public IActionResult Team()
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
