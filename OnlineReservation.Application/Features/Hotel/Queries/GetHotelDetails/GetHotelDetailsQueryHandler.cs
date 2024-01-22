using AutoMapper;
using MediatR;
using OnlineReservation.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineReservation.Application.Features.Hotel.Queries.GetHotelDetails
{
    public class GetHotelDetailsQueryHandler : IRequestHandler<GetHotelDetailsQuery, HotelDetailsDto>
    {
        private readonly IMapper _mapper;
        private readonly IHotelDetailsRepository _hotelDetailsRepository;

        public GetHotelDetailsQueryHandler(IMapper mapper, IHotelDetailsRepository hotelDetailsRepository)
        {
            this._mapper = mapper;
            this._hotelDetailsRepository = hotelDetailsRepository;
        }
        public async Task<HotelDetailsDto> Handle(GetHotelDetailsQuery request, CancellationToken cancellationToken)
        {
            var hotelDetails = await _hotelDetailsRepository.GetByIdAsync(request.Id);
            var data = _mapper.Map<HotelDetailsDto>(hotelDetails);

            return data;
        }
    }
}
