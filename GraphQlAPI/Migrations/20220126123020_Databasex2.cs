using Microsoft.EntityFrameworkCore.Migrations;

namespace GraphQlAPI.Migrations
{
    public partial class Databasex2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Accounts_Accountid",
                table: "Transactions");

            migrationBuilder.RenameColumn(
                name: "Accountid",
                table: "Transactions",
                newName: "AccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_Accountid",
                table: "Transactions",
                newName: "IX_Transactions_AccountId");

            migrationBuilder.AlterColumn<int>(
                name: "AccountId",
                table: "Transactions",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Accounts_AccountId",
                table: "Transactions",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Accounts_AccountId",
                table: "Transactions");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "Transactions",
                newName: "Accountid");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_AccountId",
                table: "Transactions",
                newName: "IX_Transactions_Accountid");

            migrationBuilder.AlterColumn<int>(
                name: "Accountid",
                table: "Transactions",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Accounts_Accountid",
                table: "Transactions",
                column: "Accountid",
                principalTable: "Accounts",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
