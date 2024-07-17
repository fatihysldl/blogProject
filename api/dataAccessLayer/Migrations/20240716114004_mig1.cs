using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "authorTables",
                columns: table => new
                {
                    authorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    authorName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    mail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    password = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_authorTables", x => x.authorId);
                });

            migrationBuilder.CreateTable(
                name: "postTables",
                columns: table => new
                {
                    postId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    postHeader = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    postDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    postDescription = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RecipeHeader = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RecipeValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecipeIngredients = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    authorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_postTables", x => x.postId);
                    table.ForeignKey(
                        name: "FK_postTables_authorTables_authorId",
                        column: x => x.authorId,
                        principalTable: "authorTables",
                        principalColumn: "authorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_postTables_authorId",
                table: "postTables",
                column: "authorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "postTables");

            migrationBuilder.DropTable(
                name: "authorTables");
        }
    }
}
