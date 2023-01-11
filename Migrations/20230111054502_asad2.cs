using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sieve.HR.Migrations
{
    public partial class asad2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HR_EMP_LEAVE_APPS");
        }
    }
}
