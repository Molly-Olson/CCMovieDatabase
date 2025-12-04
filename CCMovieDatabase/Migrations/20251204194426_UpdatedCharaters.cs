using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CCMovieDatabase.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedCharaters : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 3,
                column: "Name",
                value: "Deloris played by Whoopi Goldberg");

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "Description", "MovieId", "Name" },
                values: new object[] { 4, "The no-nonsense head of the convent who helps Deloris find her way.", 7, "Mother Superior played by Maggie Smith" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 3,
                column: "Name",
                value: "Deloris");
        }
    }
}
