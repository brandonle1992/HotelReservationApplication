using System;
using System.Collections.Generic;

namespace HotelReservationApplication.Data.Entities
{
    public class Customer : Person
    {
        public Customer()
        {
            Reservations = new HashSet<Reservation>();
        }

        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
    }
}
