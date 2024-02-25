using OnlineReservation.Application.Features.Hotel.Queries.GetAllHotels;
using OnlineReservation.Domain;
using OnlineReservation.Domain.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineReservation.Application.Contracts.Persistence
{
    public interface IHotelRepository: IGenericRepository<Hotel>
    {
    }
}
