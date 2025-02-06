using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SearchTimeBackEnd.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SearchResultItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SearchResultItems", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "SearchResultItems",
                columns: new[] { "Id", "Color", "Title" },
                values: new object[,]
                {
                    { 1010, "orange", "President" },
                    { 1011, "red", "Chapstick" },
                    { 1167, "blue", "Guitar" },
                    { 1919, "green", "Beverage" },
                    { 2123, "red", "Lifeguard" },
                    { 2424, "red", "Dinosaur" },
                    { 3360, "red", "Food" },
                    { 6552, "purple", "Dress" },
                    { 6666, "purple", "Tunnel" },
                    { 7777, "red", "Planet" },
                    { 9992, "green", "Video Game" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SearchResultItems");
        }
    }
}
