using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sieve.HR.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TYPE_NAME",
                table: "HR_EDU_TYPE",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

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
                    TYPE_EFFECT = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR_SALARY_TYPE", x => x.ID);
                });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HR_LEAVE_TYPE");

            migrationBuilder.DropTable(
                name: "HR_SALARY_TYPE");

            migrationBuilder.AlterColumn<string>(
                name: "TYPE_NAME",
                table: "HR_EDU_TYPE",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
