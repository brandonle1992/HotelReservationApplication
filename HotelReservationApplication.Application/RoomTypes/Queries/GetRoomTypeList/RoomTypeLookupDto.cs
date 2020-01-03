using AutoMapper;
using HotelReservationApplication.Data.Entities;
using System;

namespace HotelReservationApplication.Application.RoomTypes.Queries.GetRoomTypeList
{
    public class RoomTypeLookupDto
    {
        public Guid Id { get; set; }
        public string CharacterCode { get; set; }
        public string Description { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<RoomType, RoomTypeLookupDto>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.ID))
                .ForMember(d => d.CharacterCode, opt => opt.MapFrom(s => s.CharacterCode))
                .ForMember(d => d.Description, opt => opt.MapFrom(s => s.Description));
        }
    }
}
