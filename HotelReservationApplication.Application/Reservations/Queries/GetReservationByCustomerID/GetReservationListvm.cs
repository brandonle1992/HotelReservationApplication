using System.Collections.Generic;

namespace HotelReservationApplication.Application.Reservations.Queries.GetReservationByCustomerID
{
    public class GetReservationListvm
    {
        public IList<ReservationCLookupDto> Reservations { get; set; }
    }
}
