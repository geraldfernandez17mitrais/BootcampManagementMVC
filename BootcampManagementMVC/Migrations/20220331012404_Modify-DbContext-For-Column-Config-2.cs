using Microsoft.EntityFrameworkCore.Migrations;

namespace BootcampManagementMVC.Migrations
{
    public partial class ModifyDbContextForColumnConfig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "bootcamp_groups",
                newName: "is_active");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "is_active",
                table: "bootcamp_groups",
                newName: "IsActive");
        }
    }
}
