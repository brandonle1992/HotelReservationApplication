using AutoMapper;
using System;
using HotelReservationApplication.Application.Common.Mappings;
using HotelReservationApplication.Data.Entities;

namespace HotelReservationApplication.Application.Reservations.Queries.GetReservationList
{
    public class GetReservationListDTO : IMapFrom<Reservation>
    {
        public Guid ID { get; set; }
        public Guid CustomerID { get; set; }
        public Guid ReservationDetailID { get; set; }
        public DateTime StartReservation { get; set; }
        public DateTime EndReservation { get; set; }
        public decimal TotalPrice { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Reservation, GetReservationListDTO>();
        }

    }
}
