using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CCMovieDatabase.Migrations
{
    /// <inheritdoc />
    public partial class Added_rating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Description", "RatingId", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 5, "Live forever... and pay the price!", 1, new DateOnly(1992, 1, 1), "Death Becomes Her" },
                    { 6, "Hillarious comedy staring the pure genius of Billy Crystal and Danny DeVito", 1, new DateOnly(1987, 1, 1), "Throw Momma from the Train" }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "RatingId", "Name" },
                values: new object[] { 4, "PG" });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Description", "RatingId", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 3, "Love, Action, Adventure, Swordfights, Magic, Pirates!", 4, new DateOnly(1987, 9, 25), "The Princess Bride" },
                    { 4, "What are you gunna do? Bleed on me!", 4, new DateOnly(1975, 1, 1), "Monty Python and the Holy Grail" },
                    { 7, "Whoopi Goldberg gold", 4, new DateOnly(1992, 1, 1), "Sister Act" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 4);
        }
    }
}
