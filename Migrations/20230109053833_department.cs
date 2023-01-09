using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sieve.HR.Migrations
{
    public partial class department : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HR_DEPARTMENT");
        }
    }
}
