using Shared;
using System;
using System.Collections.Generic;

namespace Facility.Domain
{
    public class ReservationDate : Entity
    {
        public bool IsFullDay { get; set; }

        public DateTime From { get; set; }

        public DateTime To { get; set; }

        public int ReservationId { get; set; }

        public Reservation Reservation { get; set; }

        public List<ReservationItem> ReservationItems { get; set; }
    }
}