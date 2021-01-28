using AutoMapper;
using DataAccess.Data;
using Models;

namespace Business.Mapper
{
  public class MappingProfile : Profile
  {
    public MappingProfile()
    {
      // source -> target
      CreateMap<HotelRoomDTO, HotelRoom>();
      CreateMap<HotelRoom, HotelRoomDTO>();
    }
  }
}