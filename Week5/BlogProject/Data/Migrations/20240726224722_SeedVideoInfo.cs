using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedVideoInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "VideoInfos",
                columns: new[] { "VideoId", "VideoUrl" },
                values: new object[,]
                {
                    { 1, "https://www.youtube.com/watch?v=iDQAZEJK8lI&list=PLoILbKo9rG3skRCj37Kn5Zj803hhiuRK6" },
                    { 2, "https://www.youtube.com/watch?v=GCraGHx6gso" },
                    { 3, "https://www.youtube.com/watch?v=NwaabHqPHeM" },
                    { 4, "https://www.youtube.com/watch?v=tK9Oc6AEnR4" },
                    { 5, "https://www.youtube.com/watch?v=6gwF8mG3UUY" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VideoInfos",
                keyColumn: "VideoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VideoInfos",
                keyColumn: "VideoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VideoInfos",
                keyColumn: "VideoId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VideoInfos",
                keyColumn: "VideoId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VideoInfos",
                keyColumn: "VideoId",
                keyValue: 5);
        }
    }
}
