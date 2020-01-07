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
        public Guid CustomerID { get; set; }
        public Guid? EmployeeID { get; set; }

        public DateTime? StartReservation { get; set; }
        public DateTime? EndReservation { get; set; }
        public DateTime? Checkin { get; set; }
        public DateTime? Checkout { get; set; }

        public decimal TotalPrice { get; set; }



        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ReservationDetail ReservationDetails { get; set; }
    }
}
