using HotelReservationSystem.Data;

namespace HotelReservationSystem.Services
{
    public class RoomService : IRoomService
    {
        private readonly ReservationContext _context;

        public RoomService(ReservationContext context)
        {
            _context = context;
        }

        public List<Room> GetRooms()
        {
            var a = _context.Rooms.ToList();
            return _context.Rooms.ToList();
        }
    }
}
