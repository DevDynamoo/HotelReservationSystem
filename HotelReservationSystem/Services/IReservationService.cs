using HotelReservationSystem.Data;

namespace HotelReservationSystem.Services
{
    public interface IReservationService
    {

        Task<bool> SaveReservation(Reservation reservation);
    }
}
