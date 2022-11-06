
using HotelReservationSystem.Data;

namespace HotelReservationSystem.Services
{
    public class ReservationService : IReservationService
    {
        private readonly ReservationContext _context;

        public ReservationService(ReservationContext context)
        {
            _context = context;
        }

        public async Task<bool> SaveReservation(Reservation reservation)
        {
            await _context.Reservations.AddAsync(reservation);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
