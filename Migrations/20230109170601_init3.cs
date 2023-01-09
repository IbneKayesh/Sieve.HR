using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sieve.HR.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "HR_HOLIDAY_CALENDER",
                columns: table => new
                {
                    YEAR_ID = table.Column<int>(type: "int", nullable: false),
                    MONTH_ID = table.Column<int>(type: "int", nullable: false),
                    DAY_ID = table.Column<int>(type: "int", nullable: false),
                    HOLIDAY_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_HOLIDAY_CALENDER", x => new { x.YEAR_ID, x.MONTH_ID, x.DAY_ID });
                });

            migrationBuilder.CreateIndex(
                name: "IX_HR_EMP_SALARY_EMP_ID",
                table: "HR_EMP_SALARY",
                column: "EMP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HR_EMP_SALARY_SALARY_TYPE_ID",
                table: "HR_EMP_SALARY",
                column: "SALARY_TYPE_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HR_EMP_SALARY");

            migrationBuilder.DropTable(
                name: "HR_HOLIDAY_CALENDER");
        }
    }
}
