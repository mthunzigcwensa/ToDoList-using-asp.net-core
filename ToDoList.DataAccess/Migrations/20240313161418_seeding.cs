using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoList.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ToDotasks",
                columns: new[] { "Id", "CompletionDate", "Description", "Status", "Title" },
                values: new object[] { 1, null, "Maths Homework at 18:00", "pending", "Do HomeWork" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ToDotasks",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
