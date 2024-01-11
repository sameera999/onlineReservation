using OnlineReservation.Domain.Enums;

namespace OnlineReservation.Domain
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public RoomType RoomType { get; set; }
    }
}