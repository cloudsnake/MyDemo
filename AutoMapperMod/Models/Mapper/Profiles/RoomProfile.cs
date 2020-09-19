using AutoMapper;
using AutoMapperMod.Models.DoMain;
using AutoMapperMod.Models.Dto;

namespace AutoMapperMod.Models.Mapper.Profiles
{
    public class RoomProfile : Profile
    {
        public RoomProfile()
        {
            CreateMap<Room, RoomDto>();
            CreateMap<RoomDto, Room>();

        }
    }
}