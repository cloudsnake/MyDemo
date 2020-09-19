using System.Collections.Generic;

namespace AutoMapperMod.Models.Dto
{
    public class UserDto
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public virtual ICollection<RoomDto> RoomDtos { get; set; }
    }
}