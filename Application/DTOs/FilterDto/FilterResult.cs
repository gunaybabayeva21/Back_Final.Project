﻿using Domain.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Filter
{
    public class FilterResult
    {
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public int? Rating { get; set; }
        public bool? WiFi { get; set; }
        public bool? Pool { get; set; }
        public bool? Parking { get; set; }
        public HotelLocation? Location { get; set; }
        public bool? Breakfast { get; set; }
        public bool? Pet { get; set; }

    }
}
