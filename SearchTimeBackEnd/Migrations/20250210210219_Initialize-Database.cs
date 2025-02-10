using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SearchTimeBackEnd.Migrations
{
    /// <inheritdoc />
    public partial class InitializeDatabase : Migration
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
                    { 1, "black", "Piano" },
                    { 2, "green", "Video Game" },
                    { 3, "green", "Beverage" },
                    { 4, "purple", "Tunnel" },
                    { 5, "purple", "Dress" },
                    { 6, "purple", "Tunnel" },
                    { 7, "purple", "Microorganism" },
                    { 8, "purple", "Bench" },
                    { 9, "purple", "Monster" },
                    { 10, "purple", "Gi" },
                    { 11, "blue", "Guitar" },
                    { 12, "blue", "Ocean" },
                    { 13, "blue", "Okra" },
                    { 14, "blue", "Oscillation" },
                    { 15, "blue", "Office" },
                    { 16, "blue", "Octopus" },
                    { 17, "blue", "Chipmunk" },
                    { 18, "blue", "Tree" },
                    { 19, "blue", "Ceiling" },
                    { 20, "blue", "Eye" },
                    { 21, "blue", "Toenail" },
                    { 22, "red", "Dinosaur" },
                    { 23, "red", "Planet" },
                    { 24, "red", "Chapstick" },
                    { 25, "red", "Food" },
                    { 26, "red", "Lifeguard" },
                    { 27, "red", "Tone" },
                    { 28, "red", "Laptop" },
                    { 29, "red", "Number" },
                    { 30, "red", "Book" },
                    { 31, "red", "Library" },
                    { 32, "red", "Museum" },
                    { 33, "red", "Star" },
                    { 34, "red", "Inkling" },
                    { 35, "red", "Beast" },
                    { 36, "red", "Tenor" },
                    { 37, "red", "Paperwork" },
                    { 38, "red", "Ghoul" },
                    { 39, "red", "Car" },
                    { 40, "red", "Aircraft Carrier" },
                    { 41, "red", "Balloon" },
                    { 42, "red", "Party" },
                    { 43, "red", "System" },
                    { 44, "orange", "Orange" },
                    { 45, "orange", "Nickelodeon" },
                    { 46, "orange", "Sea" },
                    { 47, "orange", "Sunset" },
                    { 48, "orange", "Color" },
                    { 49, "orange", "Computer" },
                    { 50, "orange", "Floor" },
                    { 51, "orange", "Chair" },
                    { 52, "orange", "Chicken" },
                    { 53, "orange", "Orangutan" },
                    { 54, "orange", "Mohwak" },
                    { 55, "orange", "Tissue" },
                    { 56, "orange", "Skull" },
                    { 57, "orange", "Basement" },
                    { 58, "orange", "Nintendo" },
                    { 59, "orange", "President" },
                    { 60, "orange", "Stamp" },
                    { 61, "orange", "Basketball" },
                    { 62, "orange", "Flea" },
                    { 63, "orange", "Spider" },
                    { 64, "orange", "Tombstone" },
                    { 65, "orange", "Fashion Statement" },
                    { 66, "orange", "Sueprhero" },
                    { 67, "orange", "Shoe" },
                    { 68, "orange", "Puppet" },
                    { 69, "orange", "Design" },
                    { 70, "orange", "Crystal" },
                    { 71, "orange", "Finger" },
                    { 72, "orange", "Toe" },
                    { 73, "orange", "Sweater" },
                    { 74, "orange", "String" },
                    { 75, "orange", "Fabric" },
                    { 76, "orange", "Craft" },
                    { 77, "orange", "Glow" },
                    { 78, "orange", "Ear" }
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
