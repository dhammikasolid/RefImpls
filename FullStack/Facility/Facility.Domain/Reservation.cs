using Shared;
using System;
using System.Collections.Generic;

namespace Facility.Domain
{
    public class Reservation : Entity
    {
        public Reservation()
        {
            Dates = new List<ReservationDate>();
        }

        public decimal Amount { get; set; }

        public DateTime From { get; set; }

        public DateTime To { get; set; }

        public int FacilityId { get; set; }

        public Facility Facility { get; set; }

        public List<ReservationDate> Dates { get; set; }
    }
}