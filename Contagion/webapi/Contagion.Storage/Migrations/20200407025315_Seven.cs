using Microsoft.EntityFrameworkCore.Migrations;

namespace Contagion.Storage.Migrations
{
    public partial class Seven : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 637217799568308821L);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 637217799568324520L);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 637217799568324577L);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 637217799568324582L);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 637217799568324585L);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 637217799568324588L);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 637217799568324591L);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 637217799568324593L);

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Lat", "Lon", "UserPhone" },
                values: new object[,]
                {
                    { 637218067954092291L, 32.7286784m, -97.1046912m, 987653432L },
                    { 637218067954107378L, 32.7286784m, -97.1346912m, 8175550150L },
                    { 637218067954107436L, 32.7566784m, -97.1146912m, 8175550131L },
                    { 637218067954107441L, 32.7066784m, -97.0846912m, 8175550117L },
                    { 637218067954107444L, 32.7186784m, -97.2986532m, 8175550142L },
                    { 637218067954107447L, 32.7413513m, -97.0846912m, 8175550101L },
                    { 637218067954107450L, 32.7281164m, -97.1212765m, 8175550148L },
                    { 637218067954107454L, 32.7185123m, -97.1416348m, 8175550189L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 637218067954092291L);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 637218067954107378L);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 637218067954107436L);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 637218067954107441L);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 637218067954107444L);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 637218067954107447L);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 637218067954107450L);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 637218067954107454L);

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Lat", "Lon", "UserPhone" },
                values: new object[,]
                {
                    { 637217799568308821L, 32.7286784m, -97.1046912m, 987653432L },
                    { 637217799568324520L, 32.7286784m, -97.1346912m, 8175550150L },
                    { 637217799568324577L, 32.7566784m, -97.1146912m, 8175550131L },
                    { 637217799568324582L, 32.7066784m, -97.0846912m, 8175550117L },
                    { 637217799568324585L, 32.7186784m, -97.2986532m, 8175550142L },
                    { 637217799568324588L, 32.7413513m, -97.0846912m, 8175550101L },
                    { 637217799568324591L, 32.7281164m, -97.1212765m, 8175550148L },
                    { 637217799568324593L, 32.7185123m, -97.1416348m, 8175550189L }
                });
        }
    }
}
