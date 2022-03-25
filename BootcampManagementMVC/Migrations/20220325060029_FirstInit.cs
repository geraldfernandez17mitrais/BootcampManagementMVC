using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BootcampManagementMVC.Migrations
{
    public partial class FirstInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "belts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_belts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "bootcamp_groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Is_active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bootcamp_groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "bootcamp_members",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Full_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bootcamp_members", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "status_learnings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_status_learnings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "requests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bootcamp_group_id = table.Column<int>(type: "int", nullable: false),
                    User_id = table.Column<int>(type: "int", nullable: false),
                    Manager_user_id = table.Column<int>(type: "int", nullable: false),
                    Is_approved = table.Column<bool>(type: "bit", nullable: false),
                    Confirm_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_requests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_requests_bootcamp_groups_Bootcamp_group_id",
                        column: x => x.Bootcamp_group_id,
                        principalTable: "bootcamp_groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "syllabuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bootcamp_group_id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_syllabuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_syllabuses_bootcamp_groups_Bootcamp_group_id",
                        column: x => x.Bootcamp_group_id,
                        principalTable: "bootcamp_groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "user_bootcamps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bootcamp_group_id = table.Column<int>(type: "int", nullable: false),
                    User_id = table.Column<int>(type: "int", nullable: false),
                    Is_active = table.Column<bool>(type: "bit", nullable: false),
                    Join_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_bootcamps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_user_bootcamps_bootcamp_groups_Bootcamp_group_id",
                        column: x => x.Bootcamp_group_id,
                        principalTable: "bootcamp_groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "objectives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Syllabus_id = table.Column<int>(type: "int", nullable: false),
                    Belt_id = table.Column<int>(type: "int", nullable: false),
                    Sort_no = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_objectives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_objectives_belts_Belt_id",
                        column: x => x.Belt_id,
                        principalTable: "belts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_objectives_syllabuses_Syllabus_id",
                        column: x => x.Syllabus_id,
                        principalTable: "syllabuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "objective_items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Objective_id = table.Column<int>(type: "int", nullable: false),
                    Sort_no = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Goal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estimation_time = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_objective_items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_objective_items_objectives_Objective_id",
                        column: x => x.Objective_id,
                        principalTable: "objectives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "objective_items_status_learnings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Objective_item_id = table.Column<int>(type: "int", nullable: false),
                    Status_learning_id = table.Column<int>(type: "int", nullable: false),
                    User_id = table.Column<int>(type: "int", nullable: false),
                    Start_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_objective_items_status_learnings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_objective_items_status_learnings_objective_items_Objective_item_id",
                        column: x => x.Objective_item_id,
                        principalTable: "objective_items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_objective_items_status_learnings_status_learnings_Status_learning_id",
                        column: x => x.Status_learning_id,
                        principalTable: "status_learnings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_objective_items_Objective_id",
                table: "objective_items",
                column: "Objective_id");

            migrationBuilder.CreateIndex(
                name: "IX_objective_items_status_learnings_Objective_item_id",
                table: "objective_items_status_learnings",
                column: "Objective_item_id");

            migrationBuilder.CreateIndex(
                name: "IX_objective_items_status_learnings_Status_learning_id",
                table: "objective_items_status_learnings",
                column: "Status_learning_id");

            migrationBuilder.CreateIndex(
                name: "IX_objectives_Belt_id",
                table: "objectives",
                column: "Belt_id");

            migrationBuilder.CreateIndex(
                name: "IX_objectives_Syllabus_id",
                table: "objectives",
                column: "Syllabus_id");

            migrationBuilder.CreateIndex(
                name: "IX_requests_Bootcamp_group_id",
                table: "requests",
                column: "Bootcamp_group_id");

            migrationBuilder.CreateIndex(
                name: "IX_syllabuses_Bootcamp_group_id",
                table: "syllabuses",
                column: "Bootcamp_group_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_bootcamps_Bootcamp_group_id",
                table: "user_bootcamps",
                column: "Bootcamp_group_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bootcamp_members");

            migrationBuilder.DropTable(
                name: "objective_items_status_learnings");

            migrationBuilder.DropTable(
                name: "requests");

            migrationBuilder.DropTable(
                name: "user_bootcamps");

            migrationBuilder.DropTable(
                name: "objective_items");

            migrationBuilder.DropTable(
                name: "status_learnings");

            migrationBuilder.DropTable(
                name: "objectives");

            migrationBuilder.DropTable(
                name: "belts");

            migrationBuilder.DropTable(
                name: "syllabuses");

            migrationBuilder.DropTable(
                name: "bootcamp_groups");
        }
    }
}
