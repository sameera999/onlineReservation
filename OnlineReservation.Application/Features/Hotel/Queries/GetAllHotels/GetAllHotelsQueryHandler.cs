using AutoMapper;
using MediatR;
using OnlineReservation.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineReservation.Application.Features.Hotel.Queries.GetAllHotels
{
    public class GetAllHotelsQueryHandler : IRequestHandler<GetAllHotelsQuery, List<HotelDto>>
    {
        private readonly IMapper _mapper;
        private readonly IHotelRepository _hotelRepository;

        public GetAllHotelsQueryHandler(IMapper mapper, IHotelRepository hotelRepository)
        {
            _mapper = mapper;
            _hotelRepository = hotelRepository;
        }
        public async Task<List<HotelDto>> Handle(GetAllHotelsQuery request, CancellationToken cancellationToken)
        {
            var hotel = await _hotelRepository.GetAllAsync();
            
            var data = _mapper.Map<List<HotelDto>>(hotel);

            return data;
        }
    }
}
