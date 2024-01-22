using OnlineReservation.Domain.common;
using OnlineReservation.Domain.Enums;

namespace OnlineReservation.Domain
{
    public class Room: BaseEntity
    {       
        public int Id { get; set; }
        public string Name { get; set; }
        public RoomType RoomType { get; set; }

        public int HotelId { get; set; }
        public virtual Hotel Hotel { get; set; } = new Hotel();

    }
}