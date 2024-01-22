using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineReservation.Application.Features.Hotel.Queries.GetAllHotels
{
    public record GetAllHotelsQuery: IRequest<List<HotelDto>>;

}
