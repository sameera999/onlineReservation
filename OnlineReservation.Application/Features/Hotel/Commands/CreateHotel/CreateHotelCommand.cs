using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineReservation.Application.Features.Hotel.Commands.CreateHotel
{
    public class CreateHotelCommand: IRequest<int>
    {
        public int Id { get; set; }     
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;  
        public string PostalCode { get; set; } = string.Empty;
       public string Country { get; set; } = string.Empty;
    }
}
