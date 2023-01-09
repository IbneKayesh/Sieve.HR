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
                    MAX_SALARY = table.Column<int>(type: "int", nullable: false)
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
                    SHORT_FORM = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FULL_FORM = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PARENT_ID = table.Column<int>(type: "int", nullable: false),
                    MIN_SALARY = table.Column<int>(type: "int", nullable: false),
                    MAX_SALARY = table.Column<int>(type: "int", nullable: false)
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
                    MAX_OT_HOUR = table.Column<int>(type: "int", nullable: false)
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
                    TYPE_NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
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
                    HEAD_ID = table.Column<int>(type: "int", nullable: false)
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
                name: "HR_SECTIONS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DEPT_ID = table.Column<int>(type: "int", nullable: false),
                    SECT_NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SECT_ADDR = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    HEAD_EMP_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MAX_EMP_NO = table.Column<int>(type: "int", nullable: false),
                    MAX_SALARY = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_SECTIONS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HR_SECTIONS_HR_DEPARTMENT_DEPT_ID",
                        column: x => x.DEPT_ID,
                        principalTable: "HR_DEPARTMENT",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "HR_EDU_TYPE",
                columns: new[] { "ID", "TYPE_NAME" },
                values: new object[] { 1, "Institution" });

            migrationBuilder.InsertData(
                table: "HR_EDU_TYPE",
                columns: new[] { "ID", "TYPE_NAME" },
                values: new object[] { 2, "Training" });

            migrationBuilder.CreateIndex(
                name: "IX_HR_DEPARTMENT_COMP_ID",
                table: "HR_DEPARTMENT",
                column: "COMP_ID");

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
                name: "IX_HR_SECTIONS_DEPT_ID",
                table: "HR_SECTIONS",
                column: "DEPT_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HR_ATTENDANCE_SHEET");

            migrationBuilder.DropTable(
                name: "HR_DESIGNATIONS");

            migrationBuilder.DropTable(
                name: "HR_EDU_TYPE");

            migrationBuilder.DropTable(
                name: "HR_EMP_ROSTER");

            migrationBuilder.DropTable(
                name: "HR_SECTIONS");

            migrationBuilder.DropTable(
                name: "HR_DUTY_ROSTER");

            migrationBuilder.DropTable(
                name: "HR_EMP_DETAIL");

            migrationBuilder.DropTable(
                name: "HR_DEPARTMENT");

            migrationBuilder.DropTable(
                name: "HR_COMPANY");
        }
    }
}
