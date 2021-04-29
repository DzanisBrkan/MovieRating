using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesRatingAPI.Migrations
{
    public partial class movieUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 4,
                column: "AvgScore",
                value: 5f);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 5,
                column: "AvgScore",
                value: 4f);

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "AvgScore", "CoverImage", "Description", "ReleaseDate", "Title", "Type" },
                values: new object[,]
                {
                    { 6, 3f, "bat.png", "Dark Knight returns in second...", "22.11.2008", "Dark Knight", "Movie" },
                    { 7, 3f, "bb.png", "Breaking Bad tv series ins...", "22.11.2008", "Breaking Bad", "TV Show" },
                    { 8, 5f, "gm.png", "Green Mile is movie in...", "22.11.2008", "Green Mile", "Movie" },
                    { 9, 4f, "hp.png", "Harry Potter is movie in...", "22.11.2008", "Harry Potter", "Movie" },
                    { 10, 3f, "mos.png", "Man of Steel is movie in...", "22.11.20012", "Man of Steel", "Movie" },
                    { 11, 3f, "n.png", "Notebook is movie romantic movie...", "22.11.20012", "Notebook", "Movie" },
                    { 12, 4f, "ring.png", "Lord of the Rings movie...", "22.11.2006", "Lord of the Rings", "Movie" },
                    { 13, 5f, "ring.png", "Spiderman 3 is a movie...", "22.11.2009", "Spiderman 3", "Movie" },
                    { 14, 3f, "ring.png", "Venom is a antihero wich...", "22.11.20018", "Venom", "Movie" }
                });

            migrationBuilder.InsertData(
                table: "Rating",
                columns: new[] { "Id", "AvgScore", "Comment", "MovieId", "Score", "UserId" },
                values: new object[,]
                {
                    { 4, 5f, "Excellent series", 4, 5, 3 },
                    { 5, 4f, "Excellent movie", 5, 4, 2 }
                });

            migrationBuilder.InsertData(
                table: "Rating",
                columns: new[] { "Id", "AvgScore", "Comment", "MovieId", "Score", "UserId" },
                values: new object[,]
                {
                    { 6, 3f, "Excellent movie", 6, 3, 1 },
                    { 7, 3f, "Excellent movie", 7, 3, 2 },
                    { 8, 5f, "Excellent movie", 8, 3, 3 },
                    { 9, 4f, "Excellent movie", 9, 4, 2 },
                    { 10, 3f, "Excellent movie", 10, 3, 1 },
                    { 11, 3f, "Excellent movie", 11, 3, 2 },
                    { 12, 4f, "Excellent movie", 12, 4, 3 },
                    { 13, 5f, "Excellent movie", 13, 5, 2 },
                    { 14, 3f, "Excellent movie", 14, 3, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 4,
                column: "AvgScore",
                value: 3f);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 5,
                column: "AvgScore",
                value: 3f);
        }
    }
}
