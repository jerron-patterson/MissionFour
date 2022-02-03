using Microsoft.EntityFrameworkCore.Migrations;

namespace MissionFour.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categ",
                columns: table => new
                {
                    categoryID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    categoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categ", x => x.categoryID);
                });

            migrationBuilder.CreateTable(
                name: "entry",
                columns: table => new
                {
                    movieID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    categoryID = table.Column<int>(nullable: false),
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
                    table.ForeignKey(
                        name: "FK_entry_categ_categoryID",
                        column: x => x.categoryID,
                        principalTable: "categ",
                        principalColumn: "categoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "categ",
                columns: new[] { "categoryID", "categoryName" },
                values: new object[] { 1, "Action" });

            migrationBuilder.InsertData(
                table: "categ",
                columns: new[] { "categoryID", "categoryName" },
                values: new object[] { 2, "Romance" });

            migrationBuilder.InsertData(
                table: "categ",
                columns: new[] { "categoryID", "categoryName" },
                values: new object[] { 3, "Comedy" });

            migrationBuilder.InsertData(
                table: "categ",
                columns: new[] { "categoryID", "categoryName" },
                values: new object[] { 4, "Horror" });

            migrationBuilder.InsertData(
                table: "categ",
                columns: new[] { "categoryID", "categoryName" },
                values: new object[] { 5, "SciFi" });

            migrationBuilder.InsertData(
                table: "categ",
                columns: new[] { "categoryID", "categoryName" },
                values: new object[] { 6, "Other" });

            migrationBuilder.InsertData(
                table: "entry",
                columns: new[] { "movieID", "categoryID", "director", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 1, 1, "Jim Hentsen", false, null, null, "PG-13", "Winter Soilder", (short)2016 });

            migrationBuilder.InsertData(
                table: "entry",
                columns: new[] { "movieID", "categoryID", "director", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 2, 1, "Jim Hentsen", false, null, null, "PG-13", "Civil War", (short)2019 });

            migrationBuilder.InsertData(
                table: "entry",
                columns: new[] { "movieID", "categoryID", "director", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 3, 1, "Jim Hentsen", false, null, null, "PG-13", "End Game", (short)2020 });

            migrationBuilder.CreateIndex(
                name: "IX_entry_categoryID",
                table: "entry",
                column: "categoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "entry");

            migrationBuilder.DropTable(
                name: "categ");
        }
    }
}
