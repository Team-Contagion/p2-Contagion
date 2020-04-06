using Microsoft.EntityFrameworkCore.Migrations;

namespace Contagion.Storage.Migrations
{
    public partial class teb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserPhone = table.Column<long>(nullable: false),
                    Lat = table.Column<decimal>(nullable: false),
                    Long = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserPhone);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserPhone", "Lat", "Long" },
                values: new object[,]
                {
                    { 1234567890L, -13.12m, 16.32m },
                    { 987653432L, 32.7286784m, -97.1046912m },
                    { 1912552132L, 84.54m, -55.65m },
                    { 8888888888L, 81.54m, -56.65m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
