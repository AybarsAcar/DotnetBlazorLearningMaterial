using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Business.Repository.IRepository;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Business.Repository
{
  public class HotelRoomRepository : IHotelRoomRepository
  {
    private readonly ApplicationDbContext _db;
    private readonly IMapper _mapper;

    public HotelRoomRepository(ApplicationDbContext db, IMapper mapper)
    {
      _db = db;
      _mapper = mapper;
    }

    public async Task<HotelRoomDTO> CreateHotelRoom(HotelRoomDTO hotelRoomDto)
    {
      HotelRoom hotelRoom = _mapper.Map<HotelRoomDTO, HotelRoom>(hotelRoomDto);
      hotelRoom.CreatedAt = DateTime.Now;
      hotelRoom.CreatedBy = "";

      var addedHotelRoom = await _db.HotelRooms.AddAsync(hotelRoom);

      // save changes to db
      await _db.SaveChangesAsync();

      return _mapper.Map<HotelRoom, HotelRoomDTO>(addedHotelRoom.Entity);
    }

    public async Task<HotelRoomDTO> UpdateHotelRoom(int roomId, HotelRoomDTO hotelRoomDto)
    {
      try
      {
        if (roomId == hotelRoomDto.Id)
        {
          // valid 
          var roomDetails = await _db.HotelRooms.FindAsync(roomId);

          var room = _mapper.Map<HotelRoomDTO, HotelRoom>(hotelRoomDto, roomDetails);

          room.UpdatedBy = "";
          room.UpdatedAt = DateTime.Now;

          var updatedRoom = _db.HotelRooms.Update(room);
          await _db.SaveChangesAsync();

          return _mapper.Map<HotelRoom, HotelRoomDTO>(updatedRoom.Entity);
        }
        else
        {
          // invalid
          return null;
        }
      }
      catch (Exception e)
      {
        return null;
      }
    }

    public async Task<HotelRoomDTO> GetHotelRoom(int roomId)
    {
      try
      {
        HotelRoom hotelRoom = await _db.HotelRooms
          .Include(x => x.HotelRoomImages)
          .FirstOrDefaultAsync(x => x.Id == roomId);

        HotelRoomDTO hotelRoomDto = _mapper.Map<HotelRoom, HotelRoomDTO>(hotelRoom);
        return hotelRoomDto;
      }
      catch (Exception e)
      {
        return null;
      }
    }

    public async Task<IEnumerable<HotelRoomDTO>> GetAllHotelRooms()
    {
      try
      {
        IEnumerable<HotelRoomDTO> hotelRoomDtos =
          _mapper.Map<IEnumerable<HotelRoom>, IEnumerable<HotelRoomDTO>>(
            _db.HotelRooms.Include(x => x.HotelRoomImages));

        return hotelRoomDtos;
      }
      catch (Exception e)
      {
        return null; // if no hotel rooms exist
      }
    }

    /**
     * if unique returns null else returns the room object
     */
    public async Task<HotelRoomDTO> IsRoomUnique(string name, int roomId = 0)
    {
      try
      {
        if (roomId == 0)
        {
          HotelRoom hotelRoom = await _db.HotelRooms.FirstOrDefaultAsync(x => x.Name.ToLower() == name.ToLower());
          HotelRoomDTO hotelRoomDto = _mapper.Map<HotelRoom, HotelRoomDTO>(hotelRoom);
          return hotelRoomDto;
        }
        else
        {
          // editing
          HotelRoom hotelRoom = await _db.HotelRooms.FirstOrDefaultAsync(x => x.Name.ToLower() == name.ToLower()
                                                                              && x.Id != roomId);
          HotelRoomDTO hotelRoomDto = _mapper.Map<HotelRoom, HotelRoomDTO>(hotelRoom);
          return hotelRoomDto;
        }
      }
      catch (Exception e)
      {
        return null;
      }
    }

    public async Task<int> DeleteHotelRoom(int roomId)
    {
      var roomDetails = await _db.HotelRooms.FindAsync(roomId);

      if (roomDetails != null)
      {
        _db.HotelRooms.Remove(roomDetails);
        return await _db.SaveChangesAsync();
      }

      return 0;
    }
  }
}