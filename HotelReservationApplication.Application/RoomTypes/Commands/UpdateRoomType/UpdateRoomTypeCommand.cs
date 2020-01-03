using System;
using MediatR;

namespace HotelReservationApplication.Application.RoomTypes.Commands.UpdateRoomType
{
    public class UpdateRoomTypeCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public string CharacterCode { get; set; }
        public string Description { get; set; }
    }
}
