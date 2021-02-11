using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Repository.IRepository;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Business.Repository
{
  public class HotelRoomImageRepository : IHotelRoomImageRepository
  {
    private readonly ApplicationDbContext _db;
    private readonly IMapper _mapper;

    public HotelRoomImageRepository(ApplicationDbContext db, IMapper mapper)
    {
      _db = db;
      _mapper = mapper;
    }

    public async Task<int> CreateHotelRoomImage(HotelRoomImageDTO imageDto)
    {
      var image = _mapper.Map<HotelRoomImageDTO, HotelRoomImage>(imageDto);
      await _db.HotelRoomImages.AddAsync(image);
      
      return await _db.SaveChangesAsync(); // returns 0 if cant save changes
    }

    public async Task<int> DeleteHotelRoomImageByImageId(int imageId)
    {
      var image = await _db.HotelRoomImages.FindAsync(imageId);
      _db.HotelRoomImages.Remove(image);
      
      return await _db.SaveChangesAsync(); // returns 0 if cant save changes
    }

    public async Task<int> DeleteHotelRoomImageByRoomId(int roomId)
    {
      var images = await _db.HotelRoomImages.Where(x => x.RoomId == roomId).ToListAsync();
      
      _db.HotelRoomImages.RemoveRange(images);
      
      return await _db.SaveChangesAsync(); // returns 0 if cant save changes
    }

    public async Task<IEnumerable<HotelRoomImageDTO>> GetHotelRoomImages(int roomId)
    {
      var images = await _db.HotelRoomImages.Where(x => x.RoomId == roomId).ToListAsync();

      return _mapper.Map<IEnumerable<HotelRoomImage>, IEnumerable<HotelRoomImageDTO>>(images);
    }
  }
}