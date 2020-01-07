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

            // TODO: We will need the QueryService of GetSpecialEvent and GetRoom
        }

        public async Task<Guid> Handle(CreateReservationCommand request, CancellationToken cancellationToken)
        {

            //TDOD: We will want the information from the SpecialEvent and the BasePrice of the room
            /**
             *  Setting a variable for the Room for the base price and any fees and also will pass down the RoomID to ReservationDetail.
             *  Check to see if the SpecialEvent ID is null or not.
             *   - If SpecialEventID is not null:
             *      1) Check the Current Date to see if it is inbetween Start and End for the SpecialEvent.
             *      2) Apply a formula to apply either a discount or markup on price. Theory Formula : var percent = Discount ? 1 - (PercentChange.PercentValue / 100M) : 1 + (PercentChange.PercentValue / 100M);
             *  Pass to the CommandServiceHandler for CreateReservationDetail. This will accept 
             */
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
