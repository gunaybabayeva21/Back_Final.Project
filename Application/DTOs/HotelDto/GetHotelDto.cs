﻿using Domain.Entities;
using Domain.Entities.Enum;
using Microsoft.AspNetCore.Http;
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
        public bool WiFi { get; set; }
        public bool Pool { get; set; }
        public bool Parking { get; set; }
        public int Rating { get; set; }
        public HotelLocation Location { get; set; }
        public bool Breakfast { get; set; }
        public bool Pet { get; set; }
        public List<GetImageDto> Images { get; set; }

    }
    public class GetImageDto
    {
        public int Id { get; set; }
        public string Url { get; set; }
    }
}
