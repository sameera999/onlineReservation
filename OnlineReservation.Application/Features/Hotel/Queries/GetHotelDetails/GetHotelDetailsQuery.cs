using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineReservation.Application.Features.Hotel.Queries.GetHotelDetails
{
    public record GetHotelDetailsQuery(int Id): IRequest<HotelDetailsDto>;
    
}
