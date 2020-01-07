using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationApplication.Data.Entities
{
    public class Employee
    {
        public Employee()
        {
            Reservations = new HashSet<Reservation>();
        }
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Title { get; set; }
        public DateTime? HireDate { get; set; }


        public virtual ICollection<Reservation> Reservations { get; private set; }
    }
}
