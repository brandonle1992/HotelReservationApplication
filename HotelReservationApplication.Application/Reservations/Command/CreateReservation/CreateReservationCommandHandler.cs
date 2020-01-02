using System.Threading;
using System.Threading.Tasks;
using MediatR;
using HotelReservationApplication.Application.Common.Interfaces;
using HotelReservationApplication.Data.Entities;
using System;


namespace HotelReservationApplication.Application.Reservations.Command.CreateReservation
{
    public class CreateReservationCommandHandler : IRequestHandler<CreateReservationCommand, Guid>
    {
        private readonly IApplicationDbContext _context;

        public CreateReservationCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateReservationCommand request, CancellationToken cancellationToken)
        {
            var entity = new Reservation
            {
                CustomerID = request.CustomerID,
                EmployeeID = request.EmployeeID,
                ReservationDetailID = request.ReservationDetailID,
                StartReservation = request.StartReservation,
                EndReservation = request.EndReservation
            };

            _context.Reservations.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return entity.ID;
        }
    }
}
