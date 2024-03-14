using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ToDoList.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class seedsUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ToDotasks",
                columns: new[] { "Id", "CompletionDate", "Description", "Status", "Title" },
                values: new object[,]
                {
                    { 2, null, "By 16:00 I need To Have Taken Out Trash", "pending", "Take Out Trash" },
                    { 3, null, "My friend is coming over", "pending", "Meet Somoone" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ToDotasks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ToDotasks",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
