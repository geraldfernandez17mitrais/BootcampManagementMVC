using Microsoft.EntityFrameworkCore.Migrations;

namespace BootcampManagementMVC.Migrations
{
    public partial class ModifyDbContextForColumnConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Is_active",
                table: "bootcamp_groups",
                newName: "IsActive");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "bootcamp_groups",
                newName: "Is_active");
        }
    }
}
