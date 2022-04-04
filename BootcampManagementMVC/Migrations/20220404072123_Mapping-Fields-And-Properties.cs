using Microsoft.EntityFrameworkCore.Migrations;

namespace BootcampManagementMVC.Migrations
{
    public partial class MappingFieldsAndProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_objective_items_objectives_Objective_id",
                table: "objective_items");

            migrationBuilder.DropForeignKey(
                name: "FK_objective_items_status_learnings_objective_items_Objective_item_id",
                table: "objective_items_status_learnings");

            migrationBuilder.DropForeignKey(
                name: "FK_objective_items_status_learnings_status_learnings_Status_learning_id",
                table: "objective_items_status_learnings");

            migrationBuilder.DropForeignKey(
                name: "FK_objectives_belts_Belt_id",
                table: "objectives");

            migrationBuilder.DropForeignKey(
                name: "FK_objectives_syllabuses_Syllabus_id",
                table: "objectives");

            migrationBuilder.DropForeignKey(
                name: "FK_requests_bootcamp_groups_Bootcamp_group_id",
                table: "requests");

            migrationBuilder.DropForeignKey(
                name: "FK_syllabuses_bootcamp_groups_Bootcamp_group_id",
                table: "syllabuses");

            migrationBuilder.DropForeignKey(
                name: "FK_user_bootcamps_bootcamp_groups_Bootcamp_group_id",
                table: "user_bootcamps");

            migrationBuilder.RenameColumn(
                name: "User_id",
                table: "user_bootcamps",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "Modified_date",
                table: "user_bootcamps",
                newName: "modified_date");

            migrationBuilder.RenameColumn(
                name: "Modified_by",
                table: "user_bootcamps",
                newName: "modified_by");

            migrationBuilder.RenameColumn(
                name: "Join_date",
                table: "user_bootcamps",
                newName: "join_date");

            migrationBuilder.RenameColumn(
                name: "Is_active",
                table: "user_bootcamps",
                newName: "is_active");

            migrationBuilder.RenameColumn(
                name: "End_date",
                table: "user_bootcamps",
                newName: "end_date");

            migrationBuilder.RenameColumn(
                name: "Created_date",
                table: "user_bootcamps",
                newName: "created_date");

            migrationBuilder.RenameColumn(
                name: "Created_by",
                table: "user_bootcamps",
                newName: "created_by");

            migrationBuilder.RenameColumn(
                name: "Bootcamp_group_id",
                table: "user_bootcamps",
                newName: "bootcamp_group_id");

            migrationBuilder.RenameIndex(
                name: "IX_user_bootcamps_Bootcamp_group_id",
                table: "user_bootcamps",
                newName: "IX_user_bootcamps_bootcamp_group_id");

            migrationBuilder.RenameColumn(
                name: "Bootcamp_group_id",
                table: "syllabuses",
                newName: "bootcamp_group_id");

            migrationBuilder.RenameColumn(
                name: "Modified_date",
                table: "syllabuses",
                newName: "ModifiedDate");

            migrationBuilder.RenameColumn(
                name: "Modified_by",
                table: "syllabuses",
                newName: "ModifiedBy");

            migrationBuilder.RenameColumn(
                name: "Created_date",
                table: "syllabuses",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "Created_by",
                table: "syllabuses",
                newName: "CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_syllabuses_Bootcamp_group_id",
                table: "syllabuses",
                newName: "IX_syllabuses_bootcamp_group_id");

            migrationBuilder.RenameColumn(
                name: "Modified_date",
                table: "status_learnings",
                newName: "modified_date");

            migrationBuilder.RenameColumn(
                name: "Modified_by",
                table: "status_learnings",
                newName: "modified_by");

            migrationBuilder.RenameColumn(
                name: "Created_date",
                table: "status_learnings",
                newName: "created_date");

            migrationBuilder.RenameColumn(
                name: "Created_by",
                table: "status_learnings",
                newName: "created_by");

            migrationBuilder.RenameColumn(
                name: "User_id",
                table: "requests",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "Modified_date",
                table: "requests",
                newName: "modified_date");

            migrationBuilder.RenameColumn(
                name: "Modified_by",
                table: "requests",
                newName: "modified_by");

            migrationBuilder.RenameColumn(
                name: "Manager_user_id",
                table: "requests",
                newName: "manager_user_id");

            migrationBuilder.RenameColumn(
                name: "Is_approved",
                table: "requests",
                newName: "is_approved");

            migrationBuilder.RenameColumn(
                name: "Created_date",
                table: "requests",
                newName: "created_date");

            migrationBuilder.RenameColumn(
                name: "Created_by",
                table: "requests",
                newName: "created_by");

            migrationBuilder.RenameColumn(
                name: "Confirm_date",
                table: "requests",
                newName: "confirm_date");

            migrationBuilder.RenameColumn(
                name: "Bootcamp_group_id",
                table: "requests",
                newName: "bootcamp_group_id");

            migrationBuilder.RenameIndex(
                name: "IX_requests_Bootcamp_group_id",
                table: "requests",
                newName: "IX_requests_bootcamp_group_id");

            migrationBuilder.RenameColumn(
                name: "Syllabus_id",
                table: "objectives",
                newName: "syllabus_id");

            migrationBuilder.RenameColumn(
                name: "Sort_no",
                table: "objectives",
                newName: "sort_no");

            migrationBuilder.RenameColumn(
                name: "Modified_date",
                table: "objectives",
                newName: "modified_date");

            migrationBuilder.RenameColumn(
                name: "Modified_by",
                table: "objectives",
                newName: "modified_by");

            migrationBuilder.RenameColumn(
                name: "Created_date",
                table: "objectives",
                newName: "created_date");

            migrationBuilder.RenameColumn(
                name: "Created_by",
                table: "objectives",
                newName: "created_by");

            migrationBuilder.RenameColumn(
                name: "Belt_id",
                table: "objectives",
                newName: "belt_id");

            migrationBuilder.RenameIndex(
                name: "IX_objectives_Syllabus_id",
                table: "objectives",
                newName: "IX_objectives_syllabus_id");

            migrationBuilder.RenameIndex(
                name: "IX_objectives_Belt_id",
                table: "objectives",
                newName: "IX_objectives_belt_id");

            migrationBuilder.RenameColumn(
                name: "User_id",
                table: "objective_items_status_learnings",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "Status_learning_id",
                table: "objective_items_status_learnings",
                newName: "status_learning_id");

            migrationBuilder.RenameColumn(
                name: "Start_date",
                table: "objective_items_status_learnings",
                newName: "start_date");

            migrationBuilder.RenameColumn(
                name: "Objective_item_id",
                table: "objective_items_status_learnings",
                newName: "objective_item_id");

            migrationBuilder.RenameColumn(
                name: "Modified_date",
                table: "objective_items_status_learnings",
                newName: "modified_date");

            migrationBuilder.RenameColumn(
                name: "Modified_by",
                table: "objective_items_status_learnings",
                newName: "modified_by");

            migrationBuilder.RenameColumn(
                name: "End_date",
                table: "objective_items_status_learnings",
                newName: "end_date");

            migrationBuilder.RenameColumn(
                name: "Created_date",
                table: "objective_items_status_learnings",
                newName: "created_date");

            migrationBuilder.RenameColumn(
                name: "Created_by",
                table: "objective_items_status_learnings",
                newName: "created_by");

            migrationBuilder.RenameIndex(
                name: "IX_objective_items_status_learnings_Status_learning_id",
                table: "objective_items_status_learnings",
                newName: "IX_objective_items_status_learnings_status_learning_id");

            migrationBuilder.RenameIndex(
                name: "IX_objective_items_status_learnings_Objective_item_id",
                table: "objective_items_status_learnings",
                newName: "IX_objective_items_status_learnings_objective_item_id");

            migrationBuilder.RenameColumn(
                name: "Sort_no",
                table: "objective_items",
                newName: "sort_no");

            migrationBuilder.RenameColumn(
                name: "Objective_id",
                table: "objective_items",
                newName: "objective_id");

            migrationBuilder.RenameColumn(
                name: "Modified_date",
                table: "objective_items",
                newName: "modified_date");

            migrationBuilder.RenameColumn(
                name: "Modified_by",
                table: "objective_items",
                newName: "modified_by");

            migrationBuilder.RenameColumn(
                name: "Created_date",
                table: "objective_items",
                newName: "created_date");

            migrationBuilder.RenameColumn(
                name: "Created_by",
                table: "objective_items",
                newName: "created_by");

            migrationBuilder.RenameColumn(
                name: "Estimation_time",
                table: "objective_items",
                newName: "estimation_minute_time");

            migrationBuilder.RenameIndex(
                name: "IX_objective_items_Objective_id",
                table: "objective_items",
                newName: "IX_objective_items_objective_id");

            migrationBuilder.RenameColumn(
                name: "Modified_date",
                table: "bootcamp_members",
                newName: "modified_date");

            migrationBuilder.RenameColumn(
                name: "Modified_by",
                table: "bootcamp_members",
                newName: "modified_by");

            migrationBuilder.RenameColumn(
                name: "Full_name",
                table: "bootcamp_members",
                newName: "full_name");

            migrationBuilder.RenameColumn(
                name: "Created_date",
                table: "bootcamp_members",
                newName: "created_date");

            migrationBuilder.RenameColumn(
                name: "Created_by",
                table: "bootcamp_members",
                newName: "created_by");

            migrationBuilder.RenameColumn(
                name: "Modified_date",
                table: "bootcamp_groups",
                newName: "modified_date");

            migrationBuilder.RenameColumn(
                name: "Modified_by",
                table: "bootcamp_groups",
                newName: "modified_by");

            migrationBuilder.RenameColumn(
                name: "Created_date",
                table: "bootcamp_groups",
                newName: "created_date");

            migrationBuilder.RenameColumn(
                name: "Created_by",
                table: "bootcamp_groups",
                newName: "created_by");

            migrationBuilder.RenameColumn(
                name: "Modified_date",
                table: "belts",
                newName: "modified_date");

            migrationBuilder.RenameColumn(
                name: "Modified_by",
                table: "belts",
                newName: "modified_by");

            migrationBuilder.RenameColumn(
                name: "Created_date",
                table: "belts",
                newName: "created_date");

            migrationBuilder.RenameColumn(
                name: "Created_by",
                table: "belts",
                newName: "created_by");

            migrationBuilder.AddForeignKey(
                name: "FK_objective_items_objectives_objective_id",
                table: "objective_items",
                column: "objective_id",
                principalTable: "objectives",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_objective_items_status_learnings_objective_items_objective_item_id",
                table: "objective_items_status_learnings",
                column: "objective_item_id",
                principalTable: "objective_items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_objective_items_status_learnings_status_learnings_status_learning_id",
                table: "objective_items_status_learnings",
                column: "status_learning_id",
                principalTable: "status_learnings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_objectives_belts_belt_id",
                table: "objectives",
                column: "belt_id",
                principalTable: "belts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_objectives_syllabuses_syllabus_id",
                table: "objectives",
                column: "syllabus_id",
                principalTable: "syllabuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_requests_bootcamp_groups_bootcamp_group_id",
                table: "requests",
                column: "bootcamp_group_id",
                principalTable: "bootcamp_groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_syllabuses_bootcamp_groups_bootcamp_group_id",
                table: "syllabuses",
                column: "bootcamp_group_id",
                principalTable: "bootcamp_groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_bootcamps_bootcamp_groups_bootcamp_group_id",
                table: "user_bootcamps",
                column: "bootcamp_group_id",
                principalTable: "bootcamp_groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_objective_items_objectives_objective_id",
                table: "objective_items");

            migrationBuilder.DropForeignKey(
                name: "FK_objective_items_status_learnings_objective_items_objective_item_id",
                table: "objective_items_status_learnings");

            migrationBuilder.DropForeignKey(
                name: "FK_objective_items_status_learnings_status_learnings_status_learning_id",
                table: "objective_items_status_learnings");

            migrationBuilder.DropForeignKey(
                name: "FK_objectives_belts_belt_id",
                table: "objectives");

            migrationBuilder.DropForeignKey(
                name: "FK_objectives_syllabuses_syllabus_id",
                table: "objectives");

            migrationBuilder.DropForeignKey(
                name: "FK_requests_bootcamp_groups_bootcamp_group_id",
                table: "requests");

            migrationBuilder.DropForeignKey(
                name: "FK_syllabuses_bootcamp_groups_bootcamp_group_id",
                table: "syllabuses");

            migrationBuilder.DropForeignKey(
                name: "FK_user_bootcamps_bootcamp_groups_bootcamp_group_id",
                table: "user_bootcamps");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "user_bootcamps",
                newName: "User_id");

            migrationBuilder.RenameColumn(
                name: "modified_date",
                table: "user_bootcamps",
                newName: "Modified_date");

            migrationBuilder.RenameColumn(
                name: "modified_by",
                table: "user_bootcamps",
                newName: "Modified_by");

            migrationBuilder.RenameColumn(
                name: "join_date",
                table: "user_bootcamps",
                newName: "Join_date");

            migrationBuilder.RenameColumn(
                name: "is_active",
                table: "user_bootcamps",
                newName: "Is_active");

            migrationBuilder.RenameColumn(
                name: "end_date",
                table: "user_bootcamps",
                newName: "End_date");

            migrationBuilder.RenameColumn(
                name: "created_date",
                table: "user_bootcamps",
                newName: "Created_date");

            migrationBuilder.RenameColumn(
                name: "created_by",
                table: "user_bootcamps",
                newName: "Created_by");

            migrationBuilder.RenameColumn(
                name: "bootcamp_group_id",
                table: "user_bootcamps",
                newName: "Bootcamp_group_id");

            migrationBuilder.RenameIndex(
                name: "IX_user_bootcamps_bootcamp_group_id",
                table: "user_bootcamps",
                newName: "IX_user_bootcamps_Bootcamp_group_id");

            migrationBuilder.RenameColumn(
                name: "bootcamp_group_id",
                table: "syllabuses",
                newName: "Bootcamp_group_id");

            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "syllabuses",
                newName: "Modified_date");

            migrationBuilder.RenameColumn(
                name: "ModifiedBy",
                table: "syllabuses",
                newName: "Modified_by");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "syllabuses",
                newName: "Created_date");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "syllabuses",
                newName: "Created_by");

            migrationBuilder.RenameIndex(
                name: "IX_syllabuses_bootcamp_group_id",
                table: "syllabuses",
                newName: "IX_syllabuses_Bootcamp_group_id");

            migrationBuilder.RenameColumn(
                name: "modified_date",
                table: "status_learnings",
                newName: "Modified_date");

            migrationBuilder.RenameColumn(
                name: "modified_by",
                table: "status_learnings",
                newName: "Modified_by");

            migrationBuilder.RenameColumn(
                name: "created_date",
                table: "status_learnings",
                newName: "Created_date");

            migrationBuilder.RenameColumn(
                name: "created_by",
                table: "status_learnings",
                newName: "Created_by");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "requests",
                newName: "User_id");

            migrationBuilder.RenameColumn(
                name: "modified_date",
                table: "requests",
                newName: "Modified_date");

            migrationBuilder.RenameColumn(
                name: "modified_by",
                table: "requests",
                newName: "Modified_by");

            migrationBuilder.RenameColumn(
                name: "manager_user_id",
                table: "requests",
                newName: "Manager_user_id");

            migrationBuilder.RenameColumn(
                name: "is_approved",
                table: "requests",
                newName: "Is_approved");

            migrationBuilder.RenameColumn(
                name: "created_date",
                table: "requests",
                newName: "Created_date");

            migrationBuilder.RenameColumn(
                name: "created_by",
                table: "requests",
                newName: "Created_by");

            migrationBuilder.RenameColumn(
                name: "confirm_date",
                table: "requests",
                newName: "Confirm_date");

            migrationBuilder.RenameColumn(
                name: "bootcamp_group_id",
                table: "requests",
                newName: "Bootcamp_group_id");

            migrationBuilder.RenameIndex(
                name: "IX_requests_bootcamp_group_id",
                table: "requests",
                newName: "IX_requests_Bootcamp_group_id");

            migrationBuilder.RenameColumn(
                name: "syllabus_id",
                table: "objectives",
                newName: "Syllabus_id");

            migrationBuilder.RenameColumn(
                name: "sort_no",
                table: "objectives",
                newName: "Sort_no");

            migrationBuilder.RenameColumn(
                name: "modified_date",
                table: "objectives",
                newName: "Modified_date");

            migrationBuilder.RenameColumn(
                name: "modified_by",
                table: "objectives",
                newName: "Modified_by");

            migrationBuilder.RenameColumn(
                name: "created_date",
                table: "objectives",
                newName: "Created_date");

            migrationBuilder.RenameColumn(
                name: "created_by",
                table: "objectives",
                newName: "Created_by");

            migrationBuilder.RenameColumn(
                name: "belt_id",
                table: "objectives",
                newName: "Belt_id");

            migrationBuilder.RenameIndex(
                name: "IX_objectives_syllabus_id",
                table: "objectives",
                newName: "IX_objectives_Syllabus_id");

            migrationBuilder.RenameIndex(
                name: "IX_objectives_belt_id",
                table: "objectives",
                newName: "IX_objectives_Belt_id");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "objective_items_status_learnings",
                newName: "User_id");

            migrationBuilder.RenameColumn(
                name: "status_learning_id",
                table: "objective_items_status_learnings",
                newName: "Status_learning_id");

            migrationBuilder.RenameColumn(
                name: "start_date",
                table: "objective_items_status_learnings",
                newName: "Start_date");

            migrationBuilder.RenameColumn(
                name: "objective_item_id",
                table: "objective_items_status_learnings",
                newName: "Objective_item_id");

            migrationBuilder.RenameColumn(
                name: "modified_date",
                table: "objective_items_status_learnings",
                newName: "Modified_date");

            migrationBuilder.RenameColumn(
                name: "modified_by",
                table: "objective_items_status_learnings",
                newName: "Modified_by");

            migrationBuilder.RenameColumn(
                name: "end_date",
                table: "objective_items_status_learnings",
                newName: "End_date");

            migrationBuilder.RenameColumn(
                name: "created_date",
                table: "objective_items_status_learnings",
                newName: "Created_date");

            migrationBuilder.RenameColumn(
                name: "created_by",
                table: "objective_items_status_learnings",
                newName: "Created_by");

            migrationBuilder.RenameIndex(
                name: "IX_objective_items_status_learnings_status_learning_id",
                table: "objective_items_status_learnings",
                newName: "IX_objective_items_status_learnings_Status_learning_id");

            migrationBuilder.RenameIndex(
                name: "IX_objective_items_status_learnings_objective_item_id",
                table: "objective_items_status_learnings",
                newName: "IX_objective_items_status_learnings_Objective_item_id");

            migrationBuilder.RenameColumn(
                name: "sort_no",
                table: "objective_items",
                newName: "Sort_no");

            migrationBuilder.RenameColumn(
                name: "objective_id",
                table: "objective_items",
                newName: "Objective_id");

            migrationBuilder.RenameColumn(
                name: "modified_date",
                table: "objective_items",
                newName: "Modified_date");

            migrationBuilder.RenameColumn(
                name: "modified_by",
                table: "objective_items",
                newName: "Modified_by");

            migrationBuilder.RenameColumn(
                name: "created_date",
                table: "objective_items",
                newName: "Created_date");

            migrationBuilder.RenameColumn(
                name: "created_by",
                table: "objective_items",
                newName: "Created_by");

            migrationBuilder.RenameColumn(
                name: "estimation_minute_time",
                table: "objective_items",
                newName: "Estimation_time");

            migrationBuilder.RenameIndex(
                name: "IX_objective_items_objective_id",
                table: "objective_items",
                newName: "IX_objective_items_Objective_id");

            migrationBuilder.RenameColumn(
                name: "modified_date",
                table: "bootcamp_members",
                newName: "Modified_date");

            migrationBuilder.RenameColumn(
                name: "modified_by",
                table: "bootcamp_members",
                newName: "Modified_by");

            migrationBuilder.RenameColumn(
                name: "full_name",
                table: "bootcamp_members",
                newName: "Full_name");

            migrationBuilder.RenameColumn(
                name: "created_date",
                table: "bootcamp_members",
                newName: "Created_date");

            migrationBuilder.RenameColumn(
                name: "created_by",
                table: "bootcamp_members",
                newName: "Created_by");

            migrationBuilder.RenameColumn(
                name: "modified_date",
                table: "bootcamp_groups",
                newName: "Modified_date");

            migrationBuilder.RenameColumn(
                name: "modified_by",
                table: "bootcamp_groups",
                newName: "Modified_by");

            migrationBuilder.RenameColumn(
                name: "created_date",
                table: "bootcamp_groups",
                newName: "Created_date");

            migrationBuilder.RenameColumn(
                name: "created_by",
                table: "bootcamp_groups",
                newName: "Created_by");

            migrationBuilder.RenameColumn(
                name: "modified_date",
                table: "belts",
                newName: "Modified_date");

            migrationBuilder.RenameColumn(
                name: "modified_by",
                table: "belts",
                newName: "Modified_by");

            migrationBuilder.RenameColumn(
                name: "created_date",
                table: "belts",
                newName: "Created_date");

            migrationBuilder.RenameColumn(
                name: "created_by",
                table: "belts",
                newName: "Created_by");

            migrationBuilder.AddForeignKey(
                name: "FK_objective_items_objectives_Objective_id",
                table: "objective_items",
                column: "Objective_id",
                principalTable: "objectives",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_objective_items_status_learnings_objective_items_Objective_item_id",
                table: "objective_items_status_learnings",
                column: "Objective_item_id",
                principalTable: "objective_items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_objective_items_status_learnings_status_learnings_Status_learning_id",
                table: "objective_items_status_learnings",
                column: "Status_learning_id",
                principalTable: "status_learnings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_objectives_belts_Belt_id",
                table: "objectives",
                column: "Belt_id",
                principalTable: "belts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_objectives_syllabuses_Syllabus_id",
                table: "objectives",
                column: "Syllabus_id",
                principalTable: "syllabuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_requests_bootcamp_groups_Bootcamp_group_id",
                table: "requests",
                column: "Bootcamp_group_id",
                principalTable: "bootcamp_groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_syllabuses_bootcamp_groups_Bootcamp_group_id",
                table: "syllabuses",
                column: "Bootcamp_group_id",
                principalTable: "bootcamp_groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_bootcamps_bootcamp_groups_Bootcamp_group_id",
                table: "user_bootcamps",
                column: "Bootcamp_group_id",
                principalTable: "bootcamp_groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
