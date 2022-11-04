using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IS_Employee_Tracker.Models
{
    public class EmployeeTrackerContext : DbContext
    {
        // Constructor
        public EmployeeTrackerContext (DbContextOptions<EmployeeTrackerContext> options) : base(options)
        {
            //blank
        }

        public DbSet<EmployeeInfo> Information { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<EmployeeInfo>().HasData(

                new EmployeeInfo
                {
                    FirstName = "Michael"
                    ,
                    LastName = "Scott"
                    ,
                    International = false
                    ,
                    Gender = "Male"
                    ,
                    EmailAddress = "Michael.Scott@dundermifflin.fake"
                    ,
                    ExpectedWorkHours = 20
                    ,
                    Semester = "Fall"
                    ,
                    Year = 2020
                    ,
                    Phone = "(888)867-5309"
                    ,
                    BYUID = "665614397"
                    ,
                    PositionType = "TA IS 201"
                    ,
                    ClassCode = "26077"
                    ,
                    EmpRecordNum = 0
                    ,
                    SupervisorName = "David Wallace"
                    ,
                    HireDate = "1/3/2020"
                    ,
                    PayRate = 15.50
                    ,
                    LastPayIncrease = "2/27/2021"
                    ,
                    PayIncreaseAmount = 0.25
                    ,
                    IncreaseInputDate = "6/27/2021"
                    ,
                    YearInProgram = "MSB Core (IS or other)"
                    ,
                    GradTuition = true
                    ,
                    NameChangeComplete = true
                    ,
                    Notes = ""
                    ,
                    Terminated = false
                    ,
                    TerminationDate = ""
                    ,
                    SurveySent = "Sent"
                    ,
                    FormSubmitted = true
                    ,
                    SubmissionDate = "1/3/2020"
                    ,
                    WorkAuthorization = true
                    ,
                    WorkAuthorizationEmailSent = "1/4/2020"
                    ,
                    BYUName = "Scott, Michael"
                },
                new EmployeeInfo
                {
                    FirstName = "Dwight"
                    ,
                    LastName = "Schrute"
                    ,
                    International = false
                    ,
                    Gender = "Male"
                    ,
                    EmailAddress = "Dwight.Schrute@dundermifflin.fake"
                    ,
                    ExpectedWorkHours = 20
                    ,
                    Semester = "Winter"
                    ,
                    Year = 2022
                    ,
                    Phone = "(888)867-5310"
                    ,
                    BYUID = "341054778"
                    ,
                    PositionType = "RA"
                    ,
                    ClassCode = "27432"
                    ,
                    EmpRecordNum = 1
                    ,
                    SupervisorName = "Michael Scott"
                    ,
                    HireDate = "1/4/2022"
                    ,
                    PayRate = 15.50
                    ,
                    LastPayIncrease = "6/30/2022"
                    ,
                    PayIncreaseAmount = 0.25
                    ,
                    IncreaseInputDate = "6/30/2022"
                    ,
                    YearInProgram = "MISM"
                    ,
                    GradTuition = true
                    ,
                    NameChangeComplete = true
                    ,
                    Notes = ""
                    ,
                    Terminated = false
                    ,
                    TerminationDate = ""
                    ,
                    SurveySent = "Sent"
                    ,
                    FormSubmitted = true
                    ,
                    SubmissionDate = "1/4/2022"
                    ,
                    WorkAuthorization = true
                    ,
                    WorkAuthorizationEmailSent = "1/5/2022"
                    ,
                    BYUName = "Schrute, Dwight"
                }

                );
        }
    }
}
