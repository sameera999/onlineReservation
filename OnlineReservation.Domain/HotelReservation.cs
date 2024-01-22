using OnlineReservation.Domain.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineReservation.Domain
{
    public class HotelReservation: BaseEntity
    {
        public int Id { get; set; }        
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; } = DateTime.Now;
        public int NoOfAdults { get; set; }
        public int NoOfChildren { get; set;}


        public int CustomerId { get; set; }
        public int HotelId { get; set; }
        public virtual Hotel Hotel { get; set; } = new Hotel();
        public ICollection<Room> ReservedRooms { get; set; }
        
    }
}
