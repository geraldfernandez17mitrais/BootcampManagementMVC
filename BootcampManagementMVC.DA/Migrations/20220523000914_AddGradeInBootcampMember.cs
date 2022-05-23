using Microsoft.EntityFrameworkCore.Migrations;

namespace BootcampManagementMVC.DA.Migrations
{
    public partial class AddGradeInBootcampMember : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Grade",
                table: "bootcamp_members",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Grade",
                table: "bootcamp_members");
        }
    }
}
