using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesRatingAPI.Migrations
{
    public partial class updateMigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "AvgScore", "CoverImage", "Description", "ReleaseDate", "Title", "Type" },
                values: new object[] { 4, 3f, "", "Marvel Tv series about falcon and winter soldier", "22.11.2021", "The Falcon and Winter Soldier", "TV Show" });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "AvgScore", "CoverImage", "Description", "ReleaseDate", "Title", "Type" },
                values: new object[] { 5, 3f, "", "Tv series about robots", "22.11.2018", "West World", "TV Show" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
