using IS_Employee_Tracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Web;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Net.Http.Headers;

namespace IS_Employee_Tracker.Controllers
{
    public class HomeController : Controller
    {
        private EmployeeTrackerContext _empContext { get; set; }

        public HomeController(EmployeeTrackerContext context)
        {
            _empContext = context;
        }

        // This is our Dashboard page
        public IActionResult Index()
        {
            return View();
        }

        public void ExportToCSV()
        {
            StringWriter sw = new StringWriter();
            sw.WriteLine("\"FirstName\", \"LastName\"");

            Response.Clear();
            Response.Headers[HeaderNames.ContentDisposition] = "attachment; filename=DemoExcel.csv";
            Response.ContentType = "text/csv";

            var employees = EmployeeInfo.DummyData();

            foreach (var employee in employees)
            {
                sw.WriteLine(string.Format("\"{0}\", \"{1}\"",
                    employee.FirstName,
                    employee.LastName));
            }
            Response.WriteAsync(sw.ToString());
            Response.Clear();
        }


        public void ExportToExcel()
        {

        }
        // This is where you input new records

        [HttpGet]
        public IActionResult Form()
        {
            ViewBag.form = "add";
            return View();
        }

        [HttpPost]
        public IActionResult Form(EmployeeInfo e)
        {
            if (ModelState.IsValid)
            {
                //primary key for adding vs editing
                //if (e.BYUID == 0)
                //{
                //    _empContext.Information.Add(e);
                //}
                //else
                //{
                //    _empContext.Update(e);
                //}
                _empContext.Update(e);
                _empContext.SaveChanges();
                return RedirectToAction("Display");
            }

            else
            {
                return View(e);
            }

        }

        // This displays a table that you can filter hypothetically
        public IActionResult Display()
        {
            var table = _empContext.Information.ToList();
            return View(table);
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
