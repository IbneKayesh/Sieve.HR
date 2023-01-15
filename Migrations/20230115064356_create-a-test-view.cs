using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sieve.HR.Migrations
{
    public partial class createatestview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE VIEW dbo.COMP_DEPT_SECT select c.COMP_NAME,DEPT_NAME,SECT_NAME from HR_COMPANY c join HR_DEPARTMENT d on c.ID=d.COMP_ID join HR_SECTIONS s on d.ID=s.DEPT_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP VIEW dbo.COMP_DEPT_SECT");
        }
    }
}
