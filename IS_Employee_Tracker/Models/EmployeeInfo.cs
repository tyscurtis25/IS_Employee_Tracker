using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IS_Employee_Tracker.Models
{
    public class EmployeeInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool International { get; set; }
        public string Gender { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }
        public int ExpectedWorkHours { get; set; }
        public string Semester { get; set; }
        public int Year { get; set; }
        [Phone]
        public string Phone { get; set; }
        [Key]
        [Required]
        public string BYUID { get; set; }
        public string PositionType { get; set; }
        public string ClassCode { get; set; }
        public int EmpRecordNum { get; set; }
        public string SupervisorName { get; set; }
        public string HireDate { get; set; }
        public double PayRate { get; set; }
        public string LastPayIncrease { get; set; }
        public double PayIncreaseAmount { get; set; }
        public string IncreaseInputDate { get; set; }
        public string YearInProgram { get; set; }
        public bool GradTuition { get; set; }
        public bool NameChangeComplete { get; set; }
        public string Notes { get; set; }
        public bool Terminated { get; set; }
        public string TerminationDate { get; set; }
        public string SurveySent { get; set; }
        public bool FormSubmitted { get; set; }
        public string SubmissionDate { get; set; }
        public bool WorkAuthorization { get; set; }
        public string WorkAuthorizationEmailSent { get; set; }
        public string BYUName { get; set; }

        
    }
}