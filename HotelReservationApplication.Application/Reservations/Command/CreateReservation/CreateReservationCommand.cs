using MediatR;
using System;

namespace HotelReservationApplication.Application.Reservations.Command.CreateReservation
{
    public class CreateReservationCommand : IRequest<Guid>
    {
        public Guid CustomerID { get; set; }
        public Guid EmployeeID { get; set; }
        public Guid ReservationDetailID { get; set; }
        public Guid RoomID { get; set; }
        public Guid EventID { get; set; }


        public DateTime StartReservation { get; set; }
        public DateTime EndReservation { get; set; }
    }
}
