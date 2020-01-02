using AutoMapper;
using System;
using HotelReservationApplication.Application.Common.Mappings;
using HotelReservationApplication.Data.Entities;

namespace HotelReservationApplication.Application.Reservations.Queries.GetReservationByCustomerID
{
    public class ReservationCLookupDto : IMapFrom<Reservation>
    {
        public Guid Id { get; set; }
        public Customer Customer { get; set; }
        public DateTime StartReservation { get; set; }
        public DateTime EndReservation { get; set; }
        public ReservationDetail Detail { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Reservation, ReservationCLookupDto>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.ID))
                .ForMember(d => d.Customer, opt => opt.MapFrom(s => s.Customer))
                .ForMember(d => d.StartReservation, opt => opt.MapFrom(s => s.StartReservation))
                .ForMember(d => d.EndReservation, opt => opt.MapFrom(s => s.EndReservation))
                .ForMember(d => d.Detail, opt => opt.MapFrom(s => s.ReservationDetails));
        }

    }
}
