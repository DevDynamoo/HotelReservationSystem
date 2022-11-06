using System.Reflection.Metadata;

namespace HotelReservationSystem.Data
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfPeople { get; set; }

        public Room(int id, string name, int numberOfPeople)
        {
            Id = id;
            Name = name;
            NumberOfPeople = numberOfPeople;
        }
    }
}
