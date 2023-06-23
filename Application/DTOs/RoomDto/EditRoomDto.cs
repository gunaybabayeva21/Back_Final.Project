﻿using Domain.Entities.Enum;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.RoomDto
{
    public class EditRoomDto
    {
       
       
        public string RoomName { get; set; }
        public int UsertId { get; set; }
        public decimal Price { get; set; }
        public int HotelId { get; set; }
        
    }
}
