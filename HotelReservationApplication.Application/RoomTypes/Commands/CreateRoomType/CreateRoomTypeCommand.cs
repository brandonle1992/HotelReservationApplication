using MediatR;
using System;


namespace HotelReservationApplication.Application.RoomTypes.Commands.CreateRoomType
{
    public class CreateRoomTypeCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public string CharacterCode { get; set; }
        public string Description { get; set; }
    }
}
