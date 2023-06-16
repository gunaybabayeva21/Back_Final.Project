﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class GetCityDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public Country Country { get; set; } = null!;
        public int CountryId { get; set; }
        public ICollection<Hotel> Hotels { get; set; } = null!;
    }
}