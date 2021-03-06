﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Contagion.Storage.Migrations
{
    public partial class TwentyFour : Migration
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
                    Lon = table.Column<decimal>(nullable: false),
                    HealthStatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "HealthStatus", "Lat", "Lon", "UserPhone" },
                values: new object[,]
                {
                    { 637218544278168393L, "Positive", 32.7286784m, -97.1046912m, 987653432L },
                    { 637218544278186175L, "Negative", 32.7286784m, -97.1346912m, 8175550150L },
                    { 637218544278186242L, "Positive", 32.7566784m, -97.1146912m, 8175550131L },
                    { 637218544278186247L, "Negative", 32.7066784m, -97.0846912m, 8175550117L },
                    { 637218544278186249L, "Positive", 32.7186784m, -97.2986532m, 8175550142L },
                    { 637218544278186252L, "Negative", 32.7413513m, -97.0846912m, 8175550101L },
                    { 637218544278186255L, "Positive", 32.7281164m, -97.1212765m, 8175550148L },
                    { 637218544278186258L, "Positive", 32.7185123m, -97.1416348m, 8175550189L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
