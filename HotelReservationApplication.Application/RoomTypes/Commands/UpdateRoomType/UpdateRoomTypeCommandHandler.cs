using HotelReservationApplication.Application.Common.Exceptions;
using HotelReservationApplication.Application.Common.Interfaces;
using HotelReservationApplication.Data.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace HotelReservationApplication.Application.RoomTypes.Commands.UpdateRoomType
{
    public class UpdateRoomTypeCommandHandler : IRequestHandler<UpdateRoomTypeCommand, Guid>
    {
        private readonly IApplicationDbContext _context;

        public UpdateRoomTypeCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Guid> Handle(UpdateRoomTypeCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.RoomType.FindAsync(request.Id);

            if(entity == null)
            {
                throw new NotFoundException(request.Description, request.Id);
            }

            entity.CharacterCode = request.CharacterCode;
            entity.Description = request.Description;

            await _context.SaveChangesAsync(cancellationToken);
            return entity.ID;
        }
    }
}
