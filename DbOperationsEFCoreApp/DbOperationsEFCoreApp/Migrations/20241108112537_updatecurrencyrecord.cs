using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DbOperationsEFCoreApp.Migrations
{
    /// <inheritdoc />
    public partial class updatecurrencyrecord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CurrencyName", "Description" },
                values: new object[] { "Pound", "GBP" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CurrencyName", "Description" },
                values: new object[] { "Dollar", "USA Dollar" });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "CurrencyName", "Description" },
                values: new object[] { 4, "Euro", "Euro" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CurrencyName", "Description" },
                values: new object[] { "GBP", "UK GBP" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CurrencyName", "Description" },
                values: new object[] { "USD", "USA Dollor" });
        }
    }
}
