using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalsApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Species = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Description", "Name", "Species" },
                values: new object[] { 1, "Long black hair, no tail", "Matilda", "Canine" });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Description", "Name", "Species" },
                values: new object[] { 2, "Orange, white spots.", "Chumley", "Feline" });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Description", "Name", "Species" },
                values: new object[] { 3, "Simese", "Missy", "Feline" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
