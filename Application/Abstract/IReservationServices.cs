﻿using Application.DTOs.HotelDto;
using Application.DTOs.ImageHotelDto;
using Application.DTOs.ReservationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstract
{
    public interface IReservationServices
    {
        Task <List<GetReservationDto>> CreateAsync(List<CreateReservationDto> reservationDto);
        Task<GetReservationDto> GetByIdAsync(int id);
        Task<GetReservationDto> GetAllAsync();
        Task ReservationDeleteAsync(int id);

    }
}
