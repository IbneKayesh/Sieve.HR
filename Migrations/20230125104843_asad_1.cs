using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sieve.HR.Migrations
{
    public partial class asad_1 : Migration
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
                    ROSTER_ID = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUser = table.Column<int>(type: "int", nullable: false),
                    UpdateUser = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
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
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUser = table.Column<int>(type: "int", nullable: false),
                    UpdateUser = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
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
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUser = table.Column<int>(type: "int", nullable: false),
                    UpdateUser = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
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
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUser = table.Column<int>(type: "int", nullable: false),
                    UpdateUser = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
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
                    TYPE_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUser = table.Column<int>(type: "int", nullable: false),
                    UpdateUser = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
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
                    EMP_NO = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
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
                    PARMANENT_ADDRESS = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUser = table.Column<int>(type: "int", nullable: false),
                    UpdateUser = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_EMP_DETAIL", x => x.ID);
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
                    APPROVED_BY = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUser = table.Column<int>(type: "int", nullable: false),
                    UpdateUser = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
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
                    LEAVE_QTY = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUser = table.Column<int>(type: "int", nullable: false),
                    UpdateUser = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
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
                    NET_PAY = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUser = table.Column<int>(type: "int", nullable: false),
                    UpdateUser = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
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
                    PAYSLIP_AMT = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUser = table.Column<int>(type: "int", nullable: false),
                    UpdateUser = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
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
                    HOLIDAY_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUser = table.Column<int>(type: "int", nullable: false),
                    UpdateUser = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
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
                    TYPE_QTY = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUser = table.Column<int>(type: "int", nullable: false),
                    UpdateUser = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
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
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUser = table.Column<int>(type: "int", nullable: false),
                    UpdateUser = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
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
                    MAX_SALARY = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUser = table.Column<int>(type: "int", nullable: false),
                    UpdateUser = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
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
                    HR_DESIGNATIONSID = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUser = table.Column<int>(type: "int", nullable: false),
                    UpdateUser = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
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
                    INSTITUE_NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUser = table.Column<int>(type: "int", nullable: false),
                    UpdateUser = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_EMP_EDU", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HR_EMP_EDU_HR_EMP_DETAIL_EMP_ID",
                        column: x => x.EMP_ID,
                        principalTable: "HR_EMP_DETAIL",
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
                    REF_ADDR = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUser = table.Column<int>(type: "int", nullable: false),
                    UpdateUser = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
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
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUser = table.Column<int>(type: "int", nullable: false),
                    UpdateUser = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
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
                    SALARY_AMNT = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUser = table.Column<int>(type: "int", nullable: false),
                    UpdateUser = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
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
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUser = table.Column<int>(type: "int", nullable: false),
                    UpdateUser = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
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
                columns: new[] { "ID", "COMP_ADDR", "COMP_NAME", "CreateDate", "CreateUser", "IsActive", "MAX_EMP_NO", "MAX_SALARY", "UpdateDate", "UpdateUser" },
                values: new object[] { 1, "Dhaka, Bangladesh", "Sieve Org", new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(8859), 1, 1, 1000, 100000000, new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(8868), 1 });

            migrationBuilder.InsertData(
                table: "HR_DESIGNATIONS",
                columns: new[] { "ID", "CreateDate", "CreateUser", "FULL_FORM", "IsActive", "MAX_SALARY", "MIN_SALARY", "PARENT_ID", "SHORT_FORM", "UpdateDate", "UpdateUser" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(8997), 1, "Cheif Executive Officer", 1, 9999999, 100000, 0, "CEO", new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(8998), 1 },
                    { 2, new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9000), 1, "Executive Director", 1, 9999999, 100000, 1, "ED", new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9000), 1 },
                    { 3, new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9002), 1, "Cheif Operating Director", 1, 9999999, 100000, 2, "COO", new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9003), 1 },
                    { 4, new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9004), 1, "General Manager", 1, 9999999, 100000, 3, "GM", new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9004), 1 },
                    { 5, new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9005), 1, "Deputy General Manager", 1, 9999999, 100000, 4, "DGM", new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9006), 1 },
                    { 6, new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9007), 1, "Assistant General Manager", 1, 9999999, 100000, 5, "AGM", new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9007), 1 },
                    { 7, new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9009), 1, "Senior Manager", 1, 9999999, 100000, 6, "SM", new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9009), 1 },
                    { 8, new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9010), 1, "Manager", 1, 9999999, 100000, 7, "M", new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9011), 1 },
                    { 9, new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9012), 1, "Deputy Manager", 1, 9999999, 100000, 8, "Dym", new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9012), 1 },
                    { 10, new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9013), 1, "Assistant Manager", 1, 9999999, 100000, 9, "AM", new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9013), 1 },
                    { 11, new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9018), 1, "Sub Assistant Manager", 1, 9999999, 100000, 10, "SAM", new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9019), 1 },
                    { 12, new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9020), 1, "Trainee Executive", 1, 9999999, 100000, 11, "TE", new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9020), 1 }
                });

            migrationBuilder.InsertData(
                table: "HR_DUTY_ROSTER",
                columns: new[] { "ID", "CreateDate", "CreateUser", "DUTY_ROSTER_NAME", "IN_TIME", "IsActive", "MAX_OT_HOUR", "OUT_TIME", "UpdateDate", "UpdateUser" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9037), 1, "General Shift", "09:00", 1, 0, "17:00", new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9038), 1 },
                    { 2, new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9125), 1, "Morning Shift", "06:00", 1, 2, "18:00", new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9125), 1 },
                    { 3, new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9127), 1, "Evening Shift", "18:00", 1, 2, "06:00", new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9127), 1 }
                });

            migrationBuilder.InsertData(
                table: "HR_EDU_TYPE",
                columns: new[] { "ID", "CreateDate", "CreateUser", "IsActive", "TYPE_NAME", "UpdateDate", "UpdateUser" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9144), 1, 1, "Institution", new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9145), 1 },
                    { 2, new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9146), 1, 1, "Training", new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9146), 1 }
                });

            migrationBuilder.InsertData(
                table: "HR_EMP_DETAIL",
                columns: new[] { "ID", "BIRTH_DATE", "CONTACT_NO", "CreateDate", "CreateUser", "EMAIL_ID", "EMP_NO", "FATHER_NAME", "FULL_NAME", "GENDER_ID", "IsActive", "MARITAIL_STATUS", "MOTHER_NAME", "NATIONALITY", "NATIONAL_ID", "PARENTS_CONACT", "PARMANENT_ADDRESS", "PASSPORT_ID", "PRESENT_ADDRESS", "SPOUSE_NAME", "UpdateDate", "UpdateUser" },
                values: new object[,]
                {
                    { 1, new DateTime(1998, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9160), "008801722688266", new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9157), 1, "ibnekayesh91@gmail.com", "EMP-00001", "Father", "Md. Ibne Kayesh", "Male", 1, "Married", "Mother", "Bangladeshi", "1234567890", "Dhaka", "Dhaka, Bangladesh", "1234567890", "Dhaka, Bangladesh", "N/A", new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9157), 1 },
                    { 2, new DateTime(1998, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9167), "008801678688266", new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9165), 1, "skasadquadir@gmail.com", "EMP-00002", "Father", "Sheikh Asad Quadir", "Male", 1, "Married", "Mother", "Bangladeshi", "1234567890", "Dhaka", "Dhaka, Bangladesh", "1234567890", "Dhaka, Bangladesh", "N/A", new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9165), 1 }
                });

            migrationBuilder.InsertData(
                table: "HR_EMP_JOB",
                columns: new[] { "ID", "APPROVED_BY", "APPROVED_DATE", "CONF_DATE", "CreateDate", "CreateUser", "DESIG_ID", "EMP_ID", "END_DATE", "GROSS_SALARY", "HR_DESIGNATIONSID", "INITIATED_BY", "INITIATED_DATE", "IsActive", "SECTION_ID", "START_DATE", "UpdateDate", "UpdateUser", "VERIFIED_BY", "VERIFIED_DATE" },
                values: new object[] { 1, 1, null, new DateTime(2023, 2, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9188), new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9184), 1, 1, 1, null, 1900000, null, 1, null, 1, 1, new DateTime(2023, 4, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9186), new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9184), 1, 1, null });

            migrationBuilder.InsertData(
                table: "HR_LEAVE_TYPE",
                columns: new[] { "ID", "CreateDate", "CreateUser", "IsActive", "TYPE_NAME", "TYPE_QTY", "UpdateDate", "UpdateUser" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9207), 1, 1, "Casual", 10, new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9207), 1 },
                    { 2, new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9209), 1, 1, "Sick", 14, new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9210), 1 },
                    { 3, new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9211), 1, 1, "Earned", 0, new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9211), 1 }
                });

            migrationBuilder.InsertData(
                table: "HR_SALARY_TYPE",
                columns: new[] { "ID", "CreateDate", "CreateUser", "IsActive", "TYPE_EFFECT", "TYPE_NAME", "UpdateDate", "UpdateUser" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9224), 1, 1, 0, "Salary", new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9225), 1 },
                    { 2, new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9227), 1, 1, 0, "House Rent", new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9228), 1 },
                    { 3, new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9229), 1, 1, 0, "Medical", new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9229), 1 },
                    { 4, new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9230), 1, 1, 0, "Transport", new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9231), 1 },
                    { 5, new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9231), 1, 1, 0, "Mobile", new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9232), 1 },
                    { 6, new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9233), 1, 1, 1, "Deposit", new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9233), 1 },
                    { 7, new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9234), 1, 1, 1, "Loan", new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9235), 1 }
                });

            migrationBuilder.InsertData(
                table: "HR_DEPARTMENT",
                columns: new[] { "ID", "COMP_ID", "CreateDate", "CreateUser", "DEPT_ADDR", "DEPT_NAME", "HEAD_EMP_ID", "IsActive", "MAX_EMP_NO", "MAX_SALARY", "UpdateDate", "UpdateUser" },
                values: new object[] { 1, 1, new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(8978), 1, "First Floor, Mail Branch", "Admin", 1, 1, 10, 1000000, new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(8978), 1 });

            migrationBuilder.InsertData(
                table: "HR_DEPARTMENT",
                columns: new[] { "ID", "COMP_ID", "CreateDate", "CreateUser", "DEPT_ADDR", "DEPT_NAME", "HEAD_EMP_ID", "IsActive", "MAX_EMP_NO", "MAX_SALARY", "UpdateDate", "UpdateUser" },
                values: new object[] { 2, 1, new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(8982), 1, "Second Floor, Mail Branch", "Sales", 2, 1, 10, 1000000, new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(8982), 1 });

            migrationBuilder.InsertData(
                table: "HR_SECTIONS",
                columns: new[] { "ID", "CreateDate", "CreateUser", "DEPT_ID", "HEAD_EMP_ID", "IsActive", "MAX_EMP_NO", "MAX_SALARY", "SECT_ADDR", "SECT_NAME", "UpdateDate", "UpdateUser" },
                values: new object[] { 1, new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9250), 1, 1, 1, 1, 10, 1000000, "First Floor, Mail Branch", "Admin", new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9250), 1 });

            migrationBuilder.InsertData(
                table: "HR_SECTIONS",
                columns: new[] { "ID", "CreateDate", "CreateUser", "DEPT_ID", "HEAD_EMP_ID", "IsActive", "MAX_EMP_NO", "MAX_SALARY", "SECT_ADDR", "SECT_NAME", "UpdateDate", "UpdateUser" },
                values: new object[] { 2, new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9252), 1, 2, 2, 1, 10, 1000000, "Second Floor, Mail Branch", "IT Product", new DateTime(2023, 1, 25, 16, 48, 43, 454, DateTimeKind.Local).AddTicks(9253), 1 });

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
                name: "IX_HR_EMP_EDU_EMP_ID",
                table: "HR_EMP_EDU",
                column: "EMP_ID");

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
