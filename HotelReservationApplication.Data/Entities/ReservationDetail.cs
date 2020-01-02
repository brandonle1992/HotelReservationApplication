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

        public float Price { get; set; }

        public Room Room { get; set; }
        public SpecialEvent? Event { get; set; }
    }
}
