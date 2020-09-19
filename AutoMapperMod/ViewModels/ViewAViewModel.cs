using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using AutoMapper;
using AutoMapperMod.Models.DoMain;
using AutoMapperMod.Models.Dto;
using AutoMapperMod.Models.Mapper;

namespace AutoMapperMod.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        public DelegateCommand TestCommand { get; set; }

        //private string _message;
        //public string Message
        //{
        //    get { return _message; }
        //    set { SetProperty(ref _message, value); }
        //}

        public ViewAViewModel()
        {
            TestCommand = new DelegateCommand(OnTest);
        }

        //private IMapper CurrentMapper()
        //{
        //    var config = new MapperConfiguration(cfg =>
        //    {
        //        cfg.AddProfile<UserProfile>();
        //    });
        //    var mapper = config.CreateMapper();
        //    return mapper;
        //}
        private void OnTest()
        {
            //Mapper.Initialize(x=>x.AddProfile<UserProfile>());
            var user = new User(){Id = 12,Age = 44,Name = "jifaf"};
            var room = new Room() {Id = 101, RoomName = "roomName"};
            user.Rooms = new List<Room>();
            user.Rooms.Add(room);
            //var dto = MappingExtensions.ToUserDto(user);

            //var dtox = user.MapTo<User, UserDto>();

            var udto = AutoMapperConfiguration.Mapper.Map<UserDto>(user);

            ICollection<RoomDto> icollectionDest = AutoMapperConfiguration.Mapper.Map<Room[], ICollection<RoomDto>>(user.Rooms.ToArray());

            int a = 0;
            //var dto = mapper.Map<UserDto>(user);
            //MessageBox.Show(dto.Name);
        }
    }
}
