using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankingApp.Migrations
{
    public partial class seedEdited : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 1,
                column: "DateOfCreation",
                value: new DateTime(2024, 7, 11, 10, 12, 20, 197, DateTimeKind.Utc).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 2,
                column: "DateOfCreation",
                value: new DateTime(2024, 7, 11, 10, 12, 20, 197, DateTimeKind.Utc).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 3,
                column: "DateOfCreation",
                value: new DateTime(2024, 7, 11, 10, 12, 20, 197, DateTimeKind.Utc).AddTicks(8625));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 4,
                column: "DateOfCreation",
                value: new DateTime(2024, 7, 11, 10, 12, 20, 197, DateTimeKind.Utc).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardNumber",
                keyValue: 1234567890123456L,
                column: "Expiry",
                value: new DateTime(2027, 7, 11, 10, 12, 20, 197, DateTimeKind.Utc).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardNumber",
                keyValue: 2345678901234567L,
                column: "Expiry",
                value: new DateTime(2026, 7, 11, 10, 12, 20, 197, DateTimeKind.Utc).AddTicks(8655));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardNumber",
                keyValue: 3456789012345678L,
                column: "Expiry",
                value: new DateTime(2027, 7, 11, 10, 12, 20, 197, DateTimeKind.Utc).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDate",
                value: new DateTime(2024, 7, 11, 10, 12, 20, 197, DateTimeKind.Utc).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CardNumber", "TransactionDate" },
                values: new object[] { 1234567890123456L, new DateTime(2024, 7, 11, 10, 12, 20, 197, DateTimeKind.Utc).AddTicks(8672) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CardNumber", "TransactionDate" },
                values: new object[] { 2345678901234567L, new DateTime(2024, 7, 11, 10, 12, 20, 197, DateTimeKind.Utc).AddTicks(8672) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CardNumber", "TransactionDate" },
                values: new object[] { 2345678901234567L, new DateTime(2024, 7, 11, 10, 12, 20, 197, DateTimeKind.Utc).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CardNumber", "TransactionDate" },
                values: new object[] { 3456789012345678L, new DateTime(2024, 7, 11, 10, 12, 20, 197, DateTimeKind.Utc).AddTicks(8674) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CardNumber", "TransactionDate" },
                values: new object[] { 3456789012345678L, new DateTime(2024, 7, 11, 10, 12, 20, 197, DateTimeKind.Utc).AddTicks(8674) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 1,
                column: "DateOfCreation",
                value: new DateTime(2024, 7, 11, 10, 7, 52, 656, DateTimeKind.Utc).AddTicks(5908));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 2,
                column: "DateOfCreation",
                value: new DateTime(2024, 7, 11, 10, 7, 52, 656, DateTimeKind.Utc).AddTicks(5912));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 3,
                column: "DateOfCreation",
                value: new DateTime(2024, 7, 11, 10, 7, 52, 656, DateTimeKind.Utc).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 4,
                column: "DateOfCreation",
                value: new DateTime(2024, 7, 11, 10, 7, 52, 656, DateTimeKind.Utc).AddTicks(5914));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardNumber",
                keyValue: 1234567890123456L,
                column: "Expiry",
                value: new DateTime(2027, 7, 11, 10, 7, 52, 656, DateTimeKind.Utc).AddTicks(5926));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardNumber",
                keyValue: 2345678901234567L,
                column: "Expiry",
                value: new DateTime(2026, 7, 11, 10, 7, 52, 656, DateTimeKind.Utc).AddTicks(5934));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardNumber",
                keyValue: 3456789012345678L,
                column: "Expiry",
                value: new DateTime(2027, 7, 11, 10, 7, 52, 656, DateTimeKind.Utc).AddTicks(5935));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDate",
                value: new DateTime(2024, 7, 11, 10, 7, 52, 656, DateTimeKind.Utc).AddTicks(5957));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CardNumber", "TransactionDate" },
                values: new object[] { 2345678901234567L, new DateTime(2024, 7, 11, 10, 7, 52, 656, DateTimeKind.Utc).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CardNumber", "TransactionDate" },
                values: new object[] { 3456789012345678L, new DateTime(2024, 7, 11, 10, 7, 52, 656, DateTimeKind.Utc).AddTicks(5959) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CardNumber", "TransactionDate" },
                values: new object[] { 3456789012345678L, new DateTime(2024, 7, 11, 10, 7, 52, 656, DateTimeKind.Utc).AddTicks(5959) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CardNumber", "TransactionDate" },
                values: new object[] { 1234567890123456L, new DateTime(2024, 7, 11, 10, 7, 52, 656, DateTimeKind.Utc).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CardNumber", "TransactionDate" },
                values: new object[] { 1234567890123456L, new DateTime(2024, 7, 11, 10, 7, 52, 656, DateTimeKind.Utc).AddTicks(5961) });
        }
    }
}
