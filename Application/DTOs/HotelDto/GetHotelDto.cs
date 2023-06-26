﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.HotelDto
{
    public class GetHotelDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int CityId { get; set; }
        public int Rating { get; set; }
       
        public List<GetImageDto> Images { get; set; }

    }
    public class GetImageDto
    {
        public int Id { get; set; }
        public string Url { get; set; }
    }
}
