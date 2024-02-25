using AutoMapper;
using MediatR;
using OnlineReservation.Application.Contracts.Persistence;
using OnlineReservation.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineReservation.Application.Features.Hotel.Commands.CreateHotel
{
    public class CreateHotelCommandHandler : IRequestHandler<CreateHotelCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly IHotelRepository _hotelRepository;

        public CreateHotelCommandHandler(IMapper mapper, IHotelRepository hotelRepository)
        {
            _mapper = mapper;
            _hotelRepository = hotelRepository;
        }
        public async Task<int> Handle(CreateHotelCommand request, CancellationToken cancellationToken)
        {
            //validate incomin data

            //convert to domain entity type
            var hotelToCreate = _mapper.Map<Domain.Hotel>(request);

            //save to database
            await _hotelRepository.CreateAsync(hotelToCreate);

            //return saved hotel with DB updated Id

            return hotelToCreate.Id;

        }
    }
}
