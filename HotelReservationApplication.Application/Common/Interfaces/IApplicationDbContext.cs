﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using HotelReservationApplication.Data.Entities;

namespace HotelReservationApplication.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Customer> Custoemrs { get; set; }
        DbSet<Employee> Employees { get; set; }
        DbSet<SpecialEvent> Events { get; set; }
        DbSet<Reservation> Reservations { get; set; }
        DbSet<Room> Rooms { get; set; }
        DbSet<ReservationDetail> ReservationDetails { get; set; }
        DbSet<RoomType> RoomType { get; set; }
    }
}
