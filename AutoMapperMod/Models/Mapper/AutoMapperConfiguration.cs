using AutoMapper;
using AutoMapperMod.Models.DoMain;
using AutoMapperMod.Models.Dto;
using AutoMapperMod.Models.Mapper.Profiles;

namespace AutoMapperMod.Models.Mapper
{
    public static class AutoMapperConfiguration
    {
        public static void Init()
        {
            MapperConfiguration = new MapperConfiguration(cfg =>
            {
                #region
                //将领域实体映射到视图实体
                //cfg.CreateMap<Model, ViewModel>();
                //cfg.CreateMap<User, UserDto>();
                //cfg.CreateMap<UserDto, User>();
                cfg.AddProfile<UserProfile>();
                #endregion
            });
            Mapper = MapperConfiguration.CreateMapper();
        }
        public static IMapper Mapper { get; private set; }
        public static MapperConfiguration MapperConfiguration { get; private set; }
    }
}