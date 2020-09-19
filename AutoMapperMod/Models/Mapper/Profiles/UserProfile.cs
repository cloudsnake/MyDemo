using AutoMapper;
using AutoMapperMod.Models.DoMain;
using AutoMapperMod.Models.Dto;

namespace AutoMapperMod.Models.Mapper.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }
    }
}