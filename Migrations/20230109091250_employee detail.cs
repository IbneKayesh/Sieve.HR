using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sieve.HR.Migrations
{
    public partial class employeedetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HR_EMP_DETAIL",
                columns: table => new
                {
                    EMP_ID = table.Column<int>(type: "int", nullable: false)
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
                    table.PrimaryKey("PK_HR_EMP_DETAIL", x => x.EMP_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HR_EMP_DETAIL");
        }
    }
}
