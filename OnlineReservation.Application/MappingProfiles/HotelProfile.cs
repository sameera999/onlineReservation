using AutoMapper;
using OnlineReservation.Application.Features.Hotel.Queries.GetAllHotels;
using OnlineReservation.Application.Features.Hotel.Queries.GetHotelDetails;
using OnlineReservation.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineReservation.Application.MappingProfiles;

public class HotelProfile : Profile
{
    public HotelProfile()
    {
        CreateMap<HotelDto, Hotel>().ReverseMap();
        CreateMap<Hotel, HotelDetailsDto>();
    }
}
