using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CCMovieDatabase.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedCharacterSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "Description", "MovieId", "Name" },
                values: new object[,]
                {
                    { 5, "A yes mama kind of man who has had enough of his mama.", 6, "Owen Lift played by Danny DeVito" },
                    { 6, "He unwittingly agrees to a murder swap", 6, "Larry Donner played by Billy Crystal" },
                    { 7, "A self absorbed actress obsessed with appearance and the fountain of youth", 5, "Madeline Ashton played by the unforgettable Meryl Streep" },
                    { 8, "Heartbroken and overweight, she stumbles upon a secret that changes EVERYTHING, but is it for the better?", 5, "Helen Sharp played Goldie Hawn" },
                    { 9, "Plastic surgeon turned undertaker trapped in a loveless marriage after betrying his true love.", 5, "Ernest Menville played by Bruce Willis" },
                    { 10, "He saves the day by avoiding the silly place of Camelot and knowing the difference between an African and a European swallow. Very important distinction.", 4, "Second Swallow-Savvy Guard played by John Cleese" },
                    { 11, "Bring out your dead! He'll help ya out if they aren't in fact dead yet... and what's with that lady and her poor cat?!", 4, "Dead Collector played by Eric Idle" },
                    { 12, "A knight of the round table who uses science and logic to prove the existence of the holy grail.", 4, "Sir Bedevere the Wise played by Terry Jones" },
                    { 13, "You killed my father. Prepare to die. A skilled swordsman on a quest for revenge.", 3, "Inigo Montoya played by Mandy Patinkin" },
                    { 14, "A gentle giant with a big heart and even bigger strength, he helps Inigo on his quest.", 3, "Fezzik played by Andre the Giant" },
                    { 15, "A cunning Sicilian criminal mastermind known for his wit and intellect.", 3, "Vizzini played by Wallace Shawn" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 15);
        }
    }
}
