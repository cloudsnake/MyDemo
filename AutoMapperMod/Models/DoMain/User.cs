﻿using System.Collections.Generic;

namespace AutoMapperMod.Models.DoMain
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }
    }
}