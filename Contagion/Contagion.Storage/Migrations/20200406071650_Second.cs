using Microsoft.EntityFrameworkCore.Migrations;

namespace Contagion.Storage.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<long>(nullable: false),
                    UserPhone = table.Column<long>(nullable: false),
                    Lat = table.Column<decimal>(nullable: false),
                    Long = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Lat", "Long", "UserPhone" },
                values: new object[,]
                {
                    { 637217362103956189L, -13.12m, 16.32m, 1234567890L },
                    { 637217362103973553L, 32.7286784m, -97.1046912m, 987653432L },
                    { 637217362103973603L, 84.54m, -55.65m, 1912552132L },
                    { 637217362103973608L, 81.54m, -56.65m, 8888888888L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
