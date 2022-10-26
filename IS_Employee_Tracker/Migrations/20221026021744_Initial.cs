using Microsoft.EntityFrameworkCore.Migrations;

namespace IS_Employee_Tracker.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Information",
                columns: table => new
                {
                    BYUID = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    International = table.Column<bool>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    ExpectedWorkHours = table.Column<int>(nullable: false),
                    Semester = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    PositionType = table.Column<string>(nullable: true),
                    ClassCode = table.Column<string>(nullable: true),
                    EmpRecordNum = table.Column<int>(nullable: false),
                    SupervisorName = table.Column<string>(nullable: true),
                    HireDate = table.Column<string>(nullable: true),
                    PayRate = table.Column<double>(nullable: false),
                    LastPayIncrease = table.Column<string>(nullable: true),
                    PayIncreaseAmount = table.Column<double>(nullable: false),
                    IncreaseInputDate = table.Column<string>(nullable: true),
                    YearInProgram = table.Column<string>(nullable: true),
                    GradTuition = table.Column<bool>(nullable: false),
                    NameChangeComplete = table.Column<bool>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    Terminated = table.Column<bool>(nullable: false),
                    TerminationDate = table.Column<string>(nullable: true),
                    SurveySent = table.Column<string>(nullable: true),
                    FormSubmitted = table.Column<bool>(nullable: false),
                    SubmissionDate = table.Column<string>(nullable: true),
                    WorkAuthorization = table.Column<bool>(nullable: false),
                    WorkAuthorizationEmailSent = table.Column<string>(nullable: true),
                    BYUName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Information", x => x.BYUID);
                });

            migrationBuilder.InsertData(
                table: "Information",
                columns: new[] { "BYUID", "BYUName", "ClassCode", "EmailAddress", "EmpRecordNum", "ExpectedWorkHours", "FirstName", "FormSubmitted", "Gender", "GradTuition", "HireDate", "IncreaseInputDate", "International", "LastName", "LastPayIncrease", "NameChangeComplete", "Notes", "PayIncreaseAmount", "PayRate", "Phone", "PositionType", "Semester", "SubmissionDate", "SupervisorName", "SurveySent", "Terminated", "TerminationDate", "WorkAuthorization", "WorkAuthorizationEmailSent", "Year", "YearInProgram" },
                values: new object[] { "665614397", "Scott, Michael", "26077", "Michael.Scott@dundermifflin.fake", 0, 20, "Michael", true, "Male", true, "1/3/2020", "6/27/2021", false, "Scott", "2/27/2021", true, "", 0.25, 15.5, "(888)867-5309", "TA IS 201", "Fall", "1/3/2020", "David Wallace", "Sent", false, "", true, "1/4/2020", 2020, "MSB Core (IS or other)" });

            migrationBuilder.InsertData(
                table: "Information",
                columns: new[] { "BYUID", "BYUName", "ClassCode", "EmailAddress", "EmpRecordNum", "ExpectedWorkHours", "FirstName", "FormSubmitted", "Gender", "GradTuition", "HireDate", "IncreaseInputDate", "International", "LastName", "LastPayIncrease", "NameChangeComplete", "Notes", "PayIncreaseAmount", "PayRate", "Phone", "PositionType", "Semester", "SubmissionDate", "SupervisorName", "SurveySent", "Terminated", "TerminationDate", "WorkAuthorization", "WorkAuthorizationEmailSent", "Year", "YearInProgram" },
                values: new object[] { "341054778", "Schrute, Dwight", "27432", "Dwight.Schrute@dundermifflin.fake", 1, 20, "Dwight", true, "Male", true, "1/4/2022", "6/30/2022", false, "Schrute", "6/30/2022", true, "", 0.25, 15.5, "(888)867-5310", "RA", "Winter", "1/4/2022", "Michael Scott", "Sent", false, "", true, "1/5/2022", 2022, "MISM" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Information");
        }
    }
}
