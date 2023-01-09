using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sieve.HR.Migrations
{
    public partial class SeedOnly : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "HEAD_EMP_ID",
                table: "HR_SECTIONS",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
                    { 1, "General Shift", "0900", 0, "1700" },
                    { 2, "Morning Shift", "0600", 2, "1800" },
                    { 3, "Evening Shift", "1800", 2, "0600" }
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HR_DESIGNATIONS",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HR_DESIGNATIONS",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HR_DESIGNATIONS",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "HR_DESIGNATIONS",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "HR_DESIGNATIONS",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "HR_DESIGNATIONS",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "HR_DESIGNATIONS",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "HR_DESIGNATIONS",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "HR_DESIGNATIONS",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "HR_DESIGNATIONS",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "HR_DESIGNATIONS",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "HR_DESIGNATIONS",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "HR_DUTY_ROSTER",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HR_DUTY_ROSTER",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HR_DUTY_ROSTER",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "HR_SECTIONS",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HR_SECTIONS",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HR_DEPARTMENT",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HR_DEPARTMENT",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HR_COMPANY",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "HEAD_EMP_ID",
                table: "HR_SECTIONS",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
