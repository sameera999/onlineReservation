using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineReservation.Domain
{
    public class HotelReservation
    {
        public int  Id { get; set; }
        public Hotel Hotel { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; } = DateTime.Now;
        public int NoOfAdults { get; set; }
        public int NoOfChildren { get; set;}
        public List<Room> Rooms { get;}
    }
}
