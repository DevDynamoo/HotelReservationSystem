using System.Reflection.Metadata;

namespace HotelReservationSystem.Data
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime DateTo { get; set; }
        public DateTime DateFrom { get; set; }
        public int ReservedPeople { get; set; }
        public int RessourceId { get; set; }

        public Reservation(DateTime dateTo, DateTime dateFrom, int reservedPeople, int ressourceId)
        {
            DateTo = dateTo;
            DateFrom = dateFrom;
            ReservedPeople = reservedPeople;
            RessourceId = ressourceId;
        }
    }
    
}
