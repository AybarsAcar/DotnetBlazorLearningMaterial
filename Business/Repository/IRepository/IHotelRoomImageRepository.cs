using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace Business.Repository.IRepository
{
  public interface IHotelRoomImageRepository
  {
    public Task<int> CreateHotelRoomImage(HotelRoomImageDTO imageDto);
    
    public Task<int> DeleteHotelRoomImageByImageId(int imageId);
    
    // deletes all the images related to a room
    public Task<int> DeleteHotelRoomImageByRoomId(int roomId);

    public Task<IEnumerable<HotelRoomImageDTO>> GetHotelRoomImages(int roomId);
  }
}