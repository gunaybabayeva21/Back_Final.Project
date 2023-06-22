﻿using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Hotel:BaseAuditable
    {

        public Hotel()
        {
            Images = new HashSet<ImageHotel>();
            
        }
        public string Name { get; set; } = null!;
        public int Rating { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public ICollection<Room> Rooms { get; set; }
        public ICollection<ImageHotel> Images { get; set; }
       
    }
}
