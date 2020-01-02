using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationApplication.Data.Entities
{
    public class SpecialEvent
    {
        public SpecialEvent()
        {
            ReservationDetails = new HashSet<ReservationDetail>();
        }

        public Guid ID { get; set; }
        public Guid ReservationDetailID { get; set; }
        public float PercentChange { get; set; }
        public string? PromoCode { get; set; }
        public bool Discount { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public ICollection<ReservationDetail> ReservationDetails { get; set; }
    }
}
