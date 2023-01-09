using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sieve.HR.Migrations
{
    public partial class foreignkeytest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_HR_SECTIONS_DEPT_ID",
                table: "HR_SECTIONS",
                column: "DEPT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HR_DEPARTMENT_COMP_ID",
                table: "HR_DEPARTMENT",
                column: "COMP_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_HR_DEPARTMENT_HR_COMPANY_COMP_ID",
                table: "HR_DEPARTMENT",
                column: "COMP_ID",
                principalTable: "HR_COMPANY",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HR_SECTIONS_HR_DEPARTMENT_DEPT_ID",
                table: "HR_SECTIONS",
                column: "DEPT_ID",
                principalTable: "HR_DEPARTMENT",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HR_DEPARTMENT_HR_COMPANY_COMP_ID",
                table: "HR_DEPARTMENT");

            migrationBuilder.DropForeignKey(
                name: "FK_HR_SECTIONS_HR_DEPARTMENT_DEPT_ID",
                table: "HR_SECTIONS");

            migrationBuilder.DropIndex(
                name: "IX_HR_SECTIONS_DEPT_ID",
                table: "HR_SECTIONS");

            migrationBuilder.DropIndex(
                name: "IX_HR_DEPARTMENT_COMP_ID",
                table: "HR_DEPARTMENT");
        }
    }
}
