using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sieve.HR.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "HR_DUTY_ROSTER",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.CreateIndex(
                name: "IX_HR_DUTY_ROSTER_DUTY_ROSTER_NAME",
                table: "HR_DUTY_ROSTER",
                column: "DUTY_ROSTER_NAME",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_HR_DUTY_ROSTER_DUTY_ROSTER_NAME",
                table: "HR_DUTY_ROSTER");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "HR_DUTY_ROSTER");
        }
    }
}
