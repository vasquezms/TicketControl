using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketControl.Migrations
{
    public partial class SeedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tickets_entrances_EntranceId",
                table: "tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tickets",
                table: "tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_entrances",
                table: "entrances");

            migrationBuilder.RenameTable(
                name: "tickets",
                newName: "Tickets");

            migrationBuilder.RenameTable(
                name: "entrances",
                newName: "Entrances");

            migrationBuilder.RenameIndex(
                name: "IX_tickets_Id",
                table: "Tickets",
                newName: "IX_Tickets_Id");

            migrationBuilder.RenameIndex(
                name: "IX_tickets_EntranceId",
                table: "Tickets",
                newName: "IX_Tickets_EntranceId");

            migrationBuilder.RenameIndex(
                name: "IX_entrances_Id",
                table: "Entrances",
                newName: "IX_Entrances_Id");

            migrationBuilder.AddColumn<int>(
                name: "TicketId",
                table: "Entrances",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tickets",
                table: "Tickets",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Entrances",
                table: "Entrances",
                column: "Id");

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
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entrances_Tickets_TicketId",
                table: "Entrances");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Entrances_EntranceId",
                table: "Tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tickets",
                table: "Tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Entrances",
                table: "Entrances");

            migrationBuilder.DropIndex(
                name: "IX_Entrances_TicketId",
                table: "Entrances");

            migrationBuilder.DropColumn(
                name: "TicketId",
                table: "Entrances");

            migrationBuilder.RenameTable(
                name: "Tickets",
                newName: "tickets");

            migrationBuilder.RenameTable(
                name: "Entrances",
                newName: "entrances");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_Id",
                table: "tickets",
                newName: "IX_tickets_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_EntranceId",
                table: "tickets",
                newName: "IX_tickets_EntranceId");

            migrationBuilder.RenameIndex(
                name: "IX_Entrances_Id",
                table: "entrances",
                newName: "IX_entrances_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tickets",
                table: "tickets",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_entrances",
                table: "entrances",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tickets_entrances_EntranceId",
                table: "tickets",
                column: "EntranceId",
                principalTable: "entrances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
