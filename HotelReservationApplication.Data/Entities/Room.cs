using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationApplication.Data.Entities
{
    public class Room
    {
        public Guid ID { get; set; }
        public RoomType RoomType { get; set; }
        public float BasePrice { get; set; }

    }
}
