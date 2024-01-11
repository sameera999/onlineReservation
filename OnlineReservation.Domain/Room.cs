using OnlineReservation.Domain.common;
using OnlineReservation.Domain.Enums;

namespace OnlineReservation.Domain
{
    public class Room: BaseEntity
    {       
        public string Name { get; set; }
        public RoomType RoomType { get; set; }
    }
}