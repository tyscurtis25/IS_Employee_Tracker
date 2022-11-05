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
        private IEmpTrackerRepository _empContext { get; set; }

        public HomeController(IEmpTrackerRepository context)
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
            sw.WriteLine("\"First Name\", \"Last Name\", \"International\", \"Gender\", \"Email Address\", \"Expected Work Hours\", \"Semester\", \"Year\", \"Phone\", \"BYUID\", \"Position Type\", \"Class Code\", \"EmpRecordNum\"," +
                "\"Supervisor Name\", \"Hire Date\", \"PayRate\", \"Last Pay Increase\", \"Pay Increase Amount\", \"Increase Input Date\", \"Year In Program\", \"Grad Tuition\", \"Name Change Complete\", \"Notes\", \"Terminated\"," +
                "\"Termination Date\", \"Survey Sent\", \"Form Submitted\", \"Submission Date\", \"Work Authorization\", \"Work Authorization Email Sent\", \"BYU Name\"");
    

            Response.Clear();
            Response.Headers[HeaderNames.ContentDisposition] = "attachment; filename=AllEmployeesList.csv";
            Response.ContentType = "text/csv";

            var employees = _empContext.Information.ToList();

            foreach (var e in employees)
            {
                sw.WriteLine(string.Format("\"{0}\", \"{1}\", \"{2}\", \"{3}\", \"{4}\", \"{5}\", \"{6}\", \"{7}\", \"{8}\", \"{9}\", \"{10}\", \"{11}\", \"{12}\", \"{13}\", \"{14}\", \"{15}\", \"{16}\", " +
                    "\"{17}\", \"{18}\", \"{19}\", \"{20}\", \"{21}\", \"{22}\", \"{23}\", \"{24}\", \"{25}\", \"{26}\", \"{27}\", \"{28}\", \"{29}\", \"{30}\",",
                    e.FirstName,
                    e.LastName,
                    e.International, 
                    e.Gender,
                    e.EmailAddress,
                    e.ExpectedWorkHours,
                    e.Semester,
                    e.Year,
                    e.Phone,
                    e.BYUID,
                    e.PositionType,
                    e.ClassCode,
                    e.EmpRecordNum,
                    e.SupervisorName,
                    e.HireDate,
                    e.PayRate,
                    e.LastPayIncrease,
                    e.PayIncreaseAmount,
                    e.IncreaseInputDate,
                    e.YearInProgram,
                    e.GradTuition,
                    e.NameChangeComplete,
                    e.Notes,
                    e.Terminated,
                    e.TerminationDate,
                    e.SurveySent,
                    e.FormSubmitted,
                    e.SubmissionDate,
                    e.WorkAuthorization,
                    e.WorkAuthorizationEmailSent, 
                    e.BYUName));
            }
            Response.WriteAsync(sw.ToString());
            Response.Clear();
        }


        // This is where you input new records

        [HttpGet]
        public IActionResult Form()
        {
            //ViewBag.form = "add";
            return View();
        }

        [HttpPost]
        public IActionResult Form(EmployeeInfo e)
        {
            if (ModelState.IsValid)
            {
                _empContext.Add(e);
                _empContext.SaveChanges(e);

                return View("Display", e);
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
