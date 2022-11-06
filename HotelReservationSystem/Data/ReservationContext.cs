using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace HotelReservationSystem.Data
{
    public class ReservationContext : DbContext
    {

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        public ReservationContext(DbContextOptions<ReservationContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder options) 
        {
            base.OnConfiguring(options);
        }
    }
}
