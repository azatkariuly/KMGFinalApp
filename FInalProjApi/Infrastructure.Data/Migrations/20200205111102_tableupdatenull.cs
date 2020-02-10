using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.Migrations
{
    public partial class tableupdatenull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_problem_status_StatusId",
                table: "problem");

            migrationBuilder.DropForeignKey(
                name: "FK_problem_user_UserId",
                table: "problem");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "problem",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "StatusId",
                table: "problem",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_problem_status_StatusId",
                table: "problem",
                column: "StatusId",
                principalTable: "status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_problem_user_UserId",
                table: "problem",
                column: "UserId",
                principalTable: "user",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_problem_status_StatusId",
                table: "problem");

            migrationBuilder.DropForeignKey(
                name: "FK_problem_user_UserId",
                table: "problem");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "problem",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StatusId",
                table: "problem",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_problem_status_StatusId",
                table: "problem",
                column: "StatusId",
                principalTable: "status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_problem_user_UserId",
                table: "problem",
                column: "UserId",
                principalTable: "user",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
