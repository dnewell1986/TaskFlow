using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskFlow.WebAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class Remove_Todo_To_User_Asc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Users_AssignedToUserId1",
                table: "Todos");

            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Users_CreatedByUserId1",
                table: "Todos");

            migrationBuilder.DropIndex(
                name: "IX_Todos_AssignedToUserId1",
                table: "Todos");

            migrationBuilder.DropIndex(
                name: "IX_Todos_CreatedByUserId1",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "AssignedToUserId",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "AssignedToUserId1",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId1",
                table: "Todos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AssignedToUserId",
                table: "Todos",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "AssignedToUserId1",
                table: "Todos",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserId",
                table: "Todos",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedByUserId1",
                table: "Todos",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Todos_AssignedToUserId1",
                table: "Todos",
                column: "AssignedToUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Todos_CreatedByUserId1",
                table: "Todos",
                column: "CreatedByUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Users_AssignedToUserId1",
                table: "Todos",
                column: "AssignedToUserId1",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Users_CreatedByUserId1",
                table: "Todos",
                column: "CreatedByUserId1",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
