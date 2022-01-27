using Microsoft.EntityFrameworkCore.Migrations;

namespace MissionFour.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "entry",
                columns: table => new
                {
                    movieID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    category = table.Column<string>(nullable: false),
                    title = table.Column<string>(nullable: false),
                    year = table.Column<short>(nullable: false),
                    director = table.Column<string>(nullable: false),
                    rating = table.Column<string>(nullable: false),
                    edited = table.Column<bool>(nullable: false),
                    lentTo = table.Column<string>(nullable: true),
                    notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_entry", x => x.movieID);
                });

            migrationBuilder.InsertData(
                table: "entry",
                columns: new[] { "movieID", "category", "director", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 1, "Action", "Jim Hentsen", false, null, null, "PG-13", "Winter Soilder", (short)2016 });

            migrationBuilder.InsertData(
                table: "entry",
                columns: new[] { "movieID", "category", "director", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 2, "Action", "Jim Hentsen", false, null, null, "PG-13", "Civil War", (short)2019 });

            migrationBuilder.InsertData(
                table: "entry",
                columns: new[] { "movieID", "category", "director", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 3, "Action", "Jim Hentsen", false, null, null, "PG-13", "End Game", (short)2020 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "entry");
        }
    }
}
