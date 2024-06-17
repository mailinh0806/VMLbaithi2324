using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VMLbaithi2324.Migrations
{
    /// <inheritdoc />
    public partial class VML850Person : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VML850Person",
                columns: table => new
                {
                    VML850ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VML850Name = table.Column<string>(type: "TEXT", nullable: false),
                    VML850SoThich = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VML850Person", x => x.VML850ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VML850Person");
        }
    }
}
