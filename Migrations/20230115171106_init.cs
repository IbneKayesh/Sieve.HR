using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sieve.HR.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HR_ATTENDANCE_SHEET",
                columns: table => new
                {
                    EMP_ID = table.Column<int>(type: "int", nullable: false),
                    YEAR_ID = table.Column<int>(type: "int", nullable: false),
                    MONTH_ID = table.Column<int>(type: "int", nullable: false),
                    DAY_ID = table.Column<int>(type: "int", nullable: false),
                    IN_TIME = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    OUT_TIME = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    OT_HOURS = table.Column<int>(type: "int", nullable: false),
                    ATTEND_STATUS = table.Column<int>(type: "int", nullable: false),
                    ROSTER_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "HR_COMPANY",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    COMP_NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    COMP_ADDR = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    MAX_EMP_NO = table.Column<int>(type: "int", nullable: false),
                    MAX_SALARY = table.Column<int>(type: "int", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_COMPANY", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HR_DESIGNATIONS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SHORT_FORM = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    FULL_FORM = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PARENT_ID = table.Column<int>(type: "int", nullable: false),
                    MIN_SALARY = table.Column<int>(type: "int", nullable: false),
                    MAX_SALARY = table.Column<int>(type: "int", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_DESIGNATIONS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HR_DUTY_ROSTER",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DUTY_ROSTER_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IN_TIME = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    OUT_TIME = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    MAX_OT_HOUR = table.Column<int>(type: "int", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_DUTY_ROSTER", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HR_EDU_TYPE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TYPE_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_EDU_TYPE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HR_EMP_DETAIL",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EMP_NO = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FULL_NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CONTACT_NO = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    EMAIL_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GENDER_ID = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    NATIONALITY = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BIRTH_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MARITAIL_STATUS = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SPOUSE_NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NATIONAL_ID = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PASSPORT_ID = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FATHER_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MOTHER_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PARENTS_CONACT = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PRESENT_ADDRESS = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PARMANENT_ADDRESS = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_EMP_DETAIL", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HR_EMP_EDU",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EMP_ID = table.Column<int>(type: "int", nullable: false),
                    EDU_TYPE_ID = table.Column<int>(type: "int", nullable: false),
                    EDU_TITLE = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EDU_YEAR = table.Column<int>(type: "int", nullable: false),
                    EDU_GRADE = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    INSTITUE_NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_EMP_EDU", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HR_EMP_LEAVE_APPS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EMP_ID = table.Column<int>(type: "int", nullable: false),
                    FROM_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TO_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TOTAL_DAYS = table.Column<int>(type: "int", nullable: false),
                    LEAVE_TYPE_ID = table.Column<int>(type: "int", nullable: false),
                    LEAVE_DETAIL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VERIFY_BY = table.Column<int>(type: "int", nullable: false),
                    APPROVED_BY = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_EMP_LEAVE_APPS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HR_EMP_LEAVE_BALANCE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EMP_ID = table.Column<int>(type: "int", nullable: false),
                    YEAR_ID = table.Column<int>(type: "int", nullable: false),
                    LEAVE_QTY = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_EMP_LEAVE_BALANCE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HR_EMP_PAYSLIP",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EMP_ID = table.Column<int>(type: "int", nullable: false),
                    SECTION_ID = table.Column<int>(type: "int", nullable: false),
                    YEAR_ID = table.Column<int>(type: "int", nullable: false),
                    MONTH_ID = table.Column<int>(type: "int", nullable: false),
                    NET_PAY = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_EMP_PAYSLIP", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HR_EMP_PAYSLIP_DETAIL",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PAYSLIP_ID = table.Column<int>(type: "int", nullable: false),
                    SALARY_TYPE_ID = table.Column<int>(type: "int", nullable: false),
                    PAYSLIP_AMT = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_EMP_PAYSLIP_DETAIL", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HR_HOLIDAY_CALENDER",
                columns: table => new
                {
                    YEAR_ID = table.Column<int>(type: "int", nullable: false),
                    MONTH_ID = table.Column<int>(type: "int", nullable: false),
                    DAY_ID = table.Column<int>(type: "int", nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HOLIDAY_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_HOLIDAY_CALENDER", x => new { x.YEAR_ID, x.MONTH_ID, x.DAY_ID });
                });

            migrationBuilder.CreateTable(
                name: "HR_LEAVE_TYPE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TYPE_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TYPE_QTY = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_LEAVE_TYPE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HR_SALARY_TYPE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TYPE_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TYPE_EFFECT = table.Column<int>(type: "int", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_SALARY_TYPE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HR_DEPARTMENT",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    COMP_ID = table.Column<int>(type: "int", nullable: false),
                    DEPT_NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DEPT_ADDR = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    HEAD_EMP_ID = table.Column<int>(type: "int", nullable: false),
                    MAX_EMP_NO = table.Column<int>(type: "int", nullable: false),
                    MAX_SALARY = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_DEPARTMENT", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HR_DEPARTMENT_HR_COMPANY_COMP_ID",
                        column: x => x.COMP_ID,
                        principalTable: "HR_COMPANY",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "HR_EMP_JOB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EMP_ID = table.Column<int>(type: "int", nullable: false),
                    DESIG_ID = table.Column<int>(type: "int", nullable: false),
                    SECTION_ID = table.Column<int>(type: "int", nullable: false),
                    START_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CONF_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    END_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GROSS_SALARY = table.Column<int>(type: "int", nullable: false),
                    INITIATED_BY = table.Column<int>(type: "int", nullable: false),
                    INITIATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VERIFIED_BY = table.Column<int>(type: "int", nullable: false),
                    VERIFIED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    APPROVED_BY = table.Column<int>(type: "int", nullable: false),
                    APPROVED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HR_DESIGNATIONSID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_EMP_JOB", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HR_EMP_JOB_HR_DESIGNATIONS_HR_DESIGNATIONSID",
                        column: x => x.HR_DESIGNATIONSID,
                        principalTable: "HR_DESIGNATIONS",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "HR_EMP_REF",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EMP_ID = table.Column<int>(type: "int", nullable: false),
                    REF_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DESIGNATION = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    REF_CONTACT = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    REF_EMAIL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    REF_ADDR = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_EMP_REF", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HR_EMP_REF_HR_EMP_DETAIL_EMP_ID",
                        column: x => x.EMP_ID,
                        principalTable: "HR_EMP_DETAIL",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HR_EMP_ROSTER",
                columns: table => new
                {
                    EMP_ID = table.Column<int>(type: "int", nullable: false),
                    ROSTER_ID = table.Column<int>(type: "int", nullable: false),
                    WEEKEND_DAYNO = table.Column<int>(type: "int", nullable: false),
                    SUPERVISOR_ID = table.Column<int>(type: "int", nullable: false),
                    HEAD_ID = table.Column<int>(type: "int", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_EMP_ROSTER", x => x.EMP_ID);
                    table.ForeignKey(
                        name: "FK_HR_EMP_ROSTER_HR_DUTY_ROSTER",
                        column: x => x.ROSTER_ID,
                        principalTable: "HR_DUTY_ROSTER",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_HR_EMP_ROSTER_HR_EMP_DETAIL",
                        column: x => x.EMP_ID,
                        principalTable: "HR_EMP_DETAIL",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_HR_EMP_ROSTER_HR_EMP_HEAD",
                        column: x => x.HEAD_ID,
                        principalTable: "HR_EMP_DETAIL",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_HR_EMP_ROSTER_HR_EMP_SUPERVISOR",
                        column: x => x.SUPERVISOR_ID,
                        principalTable: "HR_EMP_DETAIL",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "HR_EMP_SALARY",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YYYYMM = table.Column<int>(type: "int", nullable: false),
                    EMP_ID = table.Column<int>(type: "int", nullable: false),
                    SALARY_TYPE_ID = table.Column<int>(type: "int", nullable: false),
                    SALARY_AMNT = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_EMP_SALARY", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HR_EMP_SALARY_HR_EMP_DETAIL_EMP_ID",
                        column: x => x.EMP_ID,
                        principalTable: "HR_EMP_DETAIL",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HR_EMP_SALARY_HR_SALARY_TYPE_SALARY_TYPE_ID",
                        column: x => x.SALARY_TYPE_ID,
                        principalTable: "HR_SALARY_TYPE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HR_SECTIONS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DEPT_ID = table.Column<int>(type: "int", nullable: false),
                    SECT_NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SECT_ADDR = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    HEAD_EMP_ID = table.Column<int>(type: "int", nullable: false),
                    MAX_EMP_NO = table.Column<int>(type: "int", nullable: false),
                    MAX_SALARY = table.Column<int>(type: "int", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_SECTIONS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HR_SECTIONS_HR_DEPARTMENT_DEPT_ID",
                        column: x => x.DEPT_ID,
                        principalTable: "HR_DEPARTMENT",
                        principalColumn: "ID");
                });

            migrationBuilder.InsertData(
                table: "HR_COMPANY",
                columns: new[] { "ID", "COMP_ADDR", "COMP_NAME", "MAX_EMP_NO", "MAX_SALARY" },
                values: new object[] { 1, "Dhaka, Bangladesh", "Sieve Org", 1000, 100000000 });

            migrationBuilder.InsertData(
                table: "HR_DESIGNATIONS",
                columns: new[] { "ID", "FULL_FORM", "MAX_SALARY", "MIN_SALARY", "PARENT_ID", "SHORT_FORM" },
                values: new object[,]
                {
                    { 1, "Cheif Executive Officer", 9999999, 100000, 0, "CEO" },
                    { 2, "Executive Director", 9999999, 100000, 1, "ED" },
                    { 3, "Cheif Operating Director", 9999999, 100000, 2, "COO" },
                    { 4, "General Manager", 9999999, 100000, 3, "GM" },
                    { 5, "Deputy General Manager", 9999999, 100000, 4, "DGM" },
                    { 6, "Assistant General Manager", 9999999, 100000, 5, "AGM" },
                    { 7, "Senior Manager", 9999999, 100000, 6, "SM" },
                    { 8, "Manager", 9999999, 100000, 7, "M" },
                    { 9, "Deputy Manager", 9999999, 100000, 8, "Dym" },
                    { 10, "Assistant Manager", 9999999, 100000, 9, "AM" },
                    { 11, "Sub Assistant Manager", 9999999, 100000, 10, "SAM" },
                    { 12, "Trainee Executive", 9999999, 100000, 11, "TE" }
                });

            migrationBuilder.InsertData(
                table: "HR_DUTY_ROSTER",
                columns: new[] { "ID", "DUTY_ROSTER_NAME", "IN_TIME", "MAX_OT_HOUR", "OUT_TIME" },
                values: new object[,]
                {
                    { 1, "General Shift", "09:00", 0, "17:00" },
                    { 2, "Morning Shift", "06:00", 2, "18:00" },
                    { 3, "Evening Shift", "18:00", 2, "06:00" }
                });

            migrationBuilder.InsertData(
                table: "HR_EDU_TYPE",
                columns: new[] { "ID", "TYPE_NAME" },
                values: new object[,]
                {
                    { 1, "Institution" },
                    { 2, "Training" }
                });

            migrationBuilder.InsertData(
                table: "HR_EMP_DETAIL",
                columns: new[] { "ID", "BIRTH_DATE", "CONTACT_NO", "EMAIL_ID", "EMP_NO", "FATHER_NAME", "FULL_NAME", "GENDER_ID", "MARITAIL_STATUS", "MOTHER_NAME", "NATIONALITY", "NATIONAL_ID", "PARENTS_CONACT", "PARMANENT_ADDRESS", "PASSPORT_ID", "PRESENT_ADDRESS", "SPOUSE_NAME" },
                values: new object[] { 1, new DateTime(1998, 1, 15, 23, 11, 5, 657, DateTimeKind.Local).AddTicks(6606), "008801722688266", "ibnekayesh91@gmail.com", "EMP-00001", "Father", "Md. Ibne Kayesh", "Male", "Married", "Mother", "Bangladeshi", "1234567890", "Dhaka", "Dhaka, Bangladesh", "1234567890", "Dhaka, Bangladesh", "N/A" });

            migrationBuilder.InsertData(
                table: "HR_EMP_JOB",
                columns: new[] { "ID", "APPROVED_BY", "APPROVED_DATE", "CONF_DATE", "DESIG_ID", "EMP_ID", "END_DATE", "GROSS_SALARY", "HR_DESIGNATIONSID", "INITIATED_BY", "INITIATED_DATE", "SECTION_ID", "START_DATE", "VERIFIED_BY", "VERIFIED_DATE" },
                values: new object[] { 1, 1, null, new DateTime(2023, 2, 15, 23, 11, 5, 657, DateTimeKind.Local).AddTicks(6702), 1, 1, null, 1900000, null, 1, null, 1, new DateTime(2023, 4, 15, 23, 11, 5, 657, DateTimeKind.Local).AddTicks(6695), 1, null });

            migrationBuilder.InsertData(
                table: "HR_LEAVE_TYPE",
                columns: new[] { "ID", "TYPE_NAME", "TYPE_QTY" },
                values: new object[,]
                {
                    { 1, "Casual", 10 },
                    { 2, "Sick", 14 },
                    { 3, "Earned", 0 }
                });

            migrationBuilder.InsertData(
                table: "HR_SALARY_TYPE",
                columns: new[] { "ID", "TYPE_EFFECT", "TYPE_NAME" },
                values: new object[,]
                {
                    { 1, 0, "Salary" },
                    { 2, 0, "House Rent" },
                    { 3, 0, "Medical" },
                    { 4, 0, "Transport" },
                    { 5, 0, "Mobile" },
                    { 6, 1, "Deposit" },
                    { 7, 1, "Loan" }
                });

            migrationBuilder.InsertData(
                table: "HR_DEPARTMENT",
                columns: new[] { "ID", "COMP_ID", "DEPT_ADDR", "DEPT_NAME", "HEAD_EMP_ID", "MAX_EMP_NO", "MAX_SALARY" },
                values: new object[] { 1, 1, "First Floor, Mail Branch", "Admin", 1, 10, 1000000 });

            migrationBuilder.InsertData(
                table: "HR_DEPARTMENT",
                columns: new[] { "ID", "COMP_ID", "DEPT_ADDR", "DEPT_NAME", "HEAD_EMP_ID", "MAX_EMP_NO", "MAX_SALARY" },
                values: new object[] { 2, 1, "Second Floor, Mail Branch", "Sales", 2, 10, 1000000 });

            migrationBuilder.InsertData(
                table: "HR_SECTIONS",
                columns: new[] { "ID", "DEPT_ID", "HEAD_EMP_ID", "MAX_EMP_NO", "MAX_SALARY", "SECT_ADDR", "SECT_NAME" },
                values: new object[] { 1, 1, 1, 10, 1000000, "First Floor, Mail Branch", "Admin" });

            migrationBuilder.InsertData(
                table: "HR_SECTIONS",
                columns: new[] { "ID", "DEPT_ID", "HEAD_EMP_ID", "MAX_EMP_NO", "MAX_SALARY", "SECT_ADDR", "SECT_NAME" },
                values: new object[] { 2, 2, 2, 10, 1000000, "Second Floor, Mail Branch", "IT Product" });

            migrationBuilder.CreateIndex(
                name: "IX_HR_COMPANY_COMP_NAME",
                table: "HR_COMPANY",
                column: "COMP_NAME",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HR_DEPARTMENT_COMP_ID",
                table: "HR_DEPARTMENT",
                column: "COMP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HR_DESIGNATIONS_SHORT_FORM",
                table: "HR_DESIGNATIONS",
                column: "SHORT_FORM",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HR_DUTY_ROSTER_DUTY_ROSTER_NAME",
                table: "HR_DUTY_ROSTER",
                column: "DUTY_ROSTER_NAME",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HR_EMP_JOB_HR_DESIGNATIONSID",
                table: "HR_EMP_JOB",
                column: "HR_DESIGNATIONSID");

            migrationBuilder.CreateIndex(
                name: "IX_HR_EMP_REF_EMP_ID",
                table: "HR_EMP_REF",
                column: "EMP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HR_EMP_ROSTER_HEAD_ID",
                table: "HR_EMP_ROSTER",
                column: "HEAD_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HR_EMP_ROSTER_ROSTER_ID",
                table: "HR_EMP_ROSTER",
                column: "ROSTER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HR_EMP_ROSTER_SUPERVISOR_ID",
                table: "HR_EMP_ROSTER",
                column: "SUPERVISOR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HR_EMP_SALARY_EMP_ID",
                table: "HR_EMP_SALARY",
                column: "EMP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HR_EMP_SALARY_SALARY_TYPE_ID",
                table: "HR_EMP_SALARY",
                column: "SALARY_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HR_SECTIONS_DEPT_ID",
                table: "HR_SECTIONS",
                column: "DEPT_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HR_ATTENDANCE_SHEET");

            migrationBuilder.DropTable(
                name: "HR_EDU_TYPE");

            migrationBuilder.DropTable(
                name: "HR_EMP_EDU");

            migrationBuilder.DropTable(
                name: "HR_EMP_JOB");

            migrationBuilder.DropTable(
                name: "HR_EMP_LEAVE_APPS");

            migrationBuilder.DropTable(
                name: "HR_EMP_LEAVE_BALANCE");

            migrationBuilder.DropTable(
                name: "HR_EMP_PAYSLIP");

            migrationBuilder.DropTable(
                name: "HR_EMP_PAYSLIP_DETAIL");

            migrationBuilder.DropTable(
                name: "HR_EMP_REF");

            migrationBuilder.DropTable(
                name: "HR_EMP_ROSTER");

            migrationBuilder.DropTable(
                name: "HR_EMP_SALARY");

            migrationBuilder.DropTable(
                name: "HR_HOLIDAY_CALENDER");

            migrationBuilder.DropTable(
                name: "HR_LEAVE_TYPE");

            migrationBuilder.DropTable(
                name: "HR_SECTIONS");

            migrationBuilder.DropTable(
                name: "HR_DESIGNATIONS");

            migrationBuilder.DropTable(
                name: "HR_DUTY_ROSTER");

            migrationBuilder.DropTable(
                name: "HR_EMP_DETAIL");

            migrationBuilder.DropTable(
                name: "HR_SALARY_TYPE");

            migrationBuilder.DropTable(
                name: "HR_DEPARTMENT");

            migrationBuilder.DropTable(
                name: "HR_COMPANY");
        }
    }
}
