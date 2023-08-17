using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DinoApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Dinos",
                columns: new[] { "DinoId", "Age", "Name", "Species" },
                values: new object[,]
                {
                    { 1, 7, "Matilda", "Woolly Mammoth" },
                    { 2, 10, "Rexie", "Dinosaur" },
                    { 3, 2, "Matilda", "Dinosaur" },
                    { 4, 4, "Pip", "Shark" },
                    { 5, 22, "Bartholomew", "Dinosaur" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dinos",
                keyColumn: "DinoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dinos",
                keyColumn: "DinoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dinos",
                keyColumn: "DinoId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dinos",
                keyColumn: "DinoId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Dinos",
                keyColumn: "DinoId",
                keyValue: 5);
        }
    }
}
