using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HotelReservationApplication.Application.Common.Exceptions;
using HotelReservationApplication.Application.Common.Interfaces;
using HotelReservationApplication.Data.Entities;
using MediatR;

namespace HotelReservationApplication.Application.RoomTypes.Commands.CreateRoomType
{
    public class CreateRoomTypeCommandHandler : IRequestHandler<CreateRoomTypeCommand, Guid>
    {
        private readonly IApplicationDbContext _context;

        public CreateRoomTypeCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Guid> Handle(CreateRoomTypeCommand request, CancellationToken cancellationToken)
        {
            var entity = new RoomType
            {
                CharacterCode = request.CharacterCode,
                Description = request.Description
            };

            _context.RoomType.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return entity.ID;
        }
    }
}
