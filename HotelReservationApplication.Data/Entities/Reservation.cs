using System;
using HotelReservationApplication.Data.Common;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationApplication.Data.Entities
{
    public class Reservation : AuditableEntity
    {
        public Guid ID { get; set; }
        public Guid ReservationDetailID { get; set; }
        public Guid CustomerGuid { get; set; }
        public Guid? EmployeeGuid { get; set; }

        public DateTime? StartReservation { get; set; }
        public DateTime? EndReservation { get; set; }
        public DateTime? Checkin { get; set; }
        public DateTime? Checkout { get; set; }



        public Customer Customer { get; set; }
        public Employee Employee { get; set; }
        public ReservationDetail ReservationDetails { get; set; }
    }
}
