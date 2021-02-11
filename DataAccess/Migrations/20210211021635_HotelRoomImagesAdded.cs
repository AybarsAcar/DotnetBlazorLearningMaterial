using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
  public partial class HotelRoomImagesAdded : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.CreateTable(
        name: "HotelRoomImages",
        columns: table => new
        {
          Id = table.Column<int>(type: "INTEGER", nullable: false)
            .Annotation("Sqlite:Autoincrement", true),
          RoomImageUrl = table.Column<string>(type: "TEXT", nullable: true),
          RoomId = table.Column<int>(type: "INTEGER", nullable: false)
        },
        constraints: table =>
        {
          table.PrimaryKey("PK_HotelRoomImages", x => x.Id);
          table.ForeignKey(
            name: "FK_HotelRoomImages_HotelRooms_RoomId",
            column: x => x.RoomId,
            principalTable: "HotelRooms",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
        });

      migrationBuilder.CreateIndex(
        name: "IX_HotelRoomImages_RoomId",
        table: "HotelRoomImages",
        column: "RoomId");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropTable(
        name: "HotelRoomImages");
    }
  }
}