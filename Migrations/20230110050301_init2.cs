using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sieve.HR.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    REF_ADDR = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
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

            migrationBuilder.CreateIndex(
                name: "IX_HR_EMP_REF_EMP_ID",
                table: "HR_EMP_REF",
                column: "EMP_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HR_EMP_REF");
        }
    }
}
