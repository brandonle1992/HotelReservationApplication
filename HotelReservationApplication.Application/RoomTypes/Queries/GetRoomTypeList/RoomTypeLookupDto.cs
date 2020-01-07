using AutoMapper;
using HotelReservationApplication.Data.Entities;
using System;

namespace HotelReservationApplication.Application.RoomTypes.Queries.GetRoomTypeList
{
    public class RoomTypeLookupDto
    {
        public Guid ID { get; set; }
        public string CharacterCode { get; set; }
        public string Description { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<RoomType, RoomTypeLookupDto>();
        }
    }
}
