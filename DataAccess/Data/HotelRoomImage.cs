using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Data
{
  /**
   * Entity to store each image for a hotel room
   */
  public class HotelRoomImage
  {
    public int Id { get; set; }

    public string RoomImageUrl { get; set; }

    // links to the room that it belongs to
    public int RoomId { get; set; }

    // specify RoomId prop as the foreign key
    [ForeignKey("RoomId")] public virtual HotelRoom HotelRoom { get; set; }
  }
}