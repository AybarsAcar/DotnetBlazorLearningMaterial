namespace Models
{
  public class HotelRoomImageDTO
  {
    public int Id { get; set; }

    public string RoomImageUrl { get; set; }

    // links to the room that it belongs to
    public int RoomId { get; set; }
  }
}