using System.Collections.Generic;

namespace HotelReservationApplication.Application.Reservations.Queries.GetReservationList
{
    public class GetReservationListvm
    {
        public IList<GetReservationLookupDTO> Reservations { get; set; }
    }
}
