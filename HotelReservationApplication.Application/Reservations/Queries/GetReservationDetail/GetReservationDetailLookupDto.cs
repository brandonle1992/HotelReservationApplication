using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationApplication.Application.Reservations.Queries.GetReservationDetail
{
    public class GetReservationDetailLookupDto
    {
        public Guid ID { get; set; }
        public string CFirstName { get; set; }
        public string CLastName { get; set; }
        public string EFirstName { get; set; }
        public string ELastName { get; set; }
        public DateTime StartReservation { get; set; }
        public DateTime EndReservation { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
