using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationApplication.Data.Entities
{
    public abstract class Person
    {
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public int MyProperty { get; set; }
    }
}
