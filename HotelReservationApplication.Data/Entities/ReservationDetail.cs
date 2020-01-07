using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationApplication.Data.Entities
{
    public class ReservationDetail
    {
        public Guid ID { get; set; }
        public Guid RoomID { get; set; }
        public Guid? EventID { get; set; }

        //Reservation Detail should show the customer itemization of the reservation.
        public decimal BasePrice { get; set; }
        public decimal TaxPrice { get; set; }
        public decimal FeePrice { get; set; }
        public decimal TotalPrice { get; set; }

        public virtual Room Room { get; set; }
        public virtual SpecialEvent? Event { get; set; }
        public virtual Reservation Reservation{ get; set; }

    }
}
