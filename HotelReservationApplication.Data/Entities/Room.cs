using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationApplication.Data.Entities
{
    public class Room
    {
        public Room()
        {
            ReservationDetails = new HashSet<ReservationDetail>();
        }

        public Guid ID { get; set; }
        public Guid RoomTypeID { get; set; }

        public RoomType RoomType { get; set; }

        public float BasePrice { get; set; }                                   //Per night price.
        public float FeeBasePrice { get; set; }                                //Flat price for overall stay.

        public virtual ICollection<ReservationDetail> ReservationDetails { get; set; } //For reporting purpose

    }
}
