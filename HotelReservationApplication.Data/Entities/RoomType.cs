using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationApplication.Data.Entities
{
    public class RoomType
    {
        public Guid ID { get; set; }
        public string CharacterCode { get; set; }
        public string Description { get; set; }
    }
}
