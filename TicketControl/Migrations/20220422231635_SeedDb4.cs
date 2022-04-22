using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketControl.Migrations
{
    public partial class SeedDb4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entrances_Tickets_TicketId",
                table: "Entrances");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Entrances_EntranceId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_Id",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Entrances_Id",
                table: "Entrances");

            migrationBuilder.DropIndex(
                name: "IX_Entrances_TicketId",
                table: "Entrances");

            migrationBuilder.DropColumn(
                name: "TicketId",
                table: "Entrances");

            migrationBuilder.AlterColumn<int>(
                name: "EntranceId",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Tickets",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_Id_EntranceId",
                table: "Tickets",
                columns: new[] { "Id", "EntranceId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Entrances_Description",
                table: "Entrances",
                column: "Description",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Entrances_EntranceId",
                table: "Tickets",
                column: "EntranceId",
                principalTable: "Entrances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Entrances_EntranceId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_Id_EntranceId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Entrances_Description",
                table: "Entrances");

            migrationBuilder.AlterColumn<int>(
                name: "EntranceId",
                table: "Tickets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Tickets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TicketId",
                table: "Entrances",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_Id",
                table: "Tickets",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Entrances_Id",
                table: "Entrances",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Entrances_TicketId",
                table: "Entrances",
                column: "TicketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Entrances_Tickets_TicketId",
                table: "Entrances",
                column: "TicketId",
                principalTable: "Tickets",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Entrances_EntranceId",
                table: "Tickets",
                column: "EntranceId",
                principalTable: "Entrances",
                principalColumn: "Id");
        }
    }
}
