using Microsoft.EntityFrameworkCore.Migrations;

namespace GraphQlAPI.Migrations
{
    public partial class DatabaseUpdatex2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Accountid",
                table: "Transactions",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_Accountid",
                table: "Transactions",
                column: "Accountid");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Accounts_Accountid",
                table: "Transactions",
                column: "Accountid",
                principalTable: "Accounts",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Accounts_Accountid",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_Accountid",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "Accountid",
                table: "Transactions");
        }
    }
}
