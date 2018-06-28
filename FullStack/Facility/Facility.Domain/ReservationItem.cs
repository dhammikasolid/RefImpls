using Shared;

namespace Facility.Domain
{
    public class ReservationItem : Entity
    {
        public decimal Quatity { get; set; }

        public int ReservationDateId { get; set; }

        public ReservationDate ReservationDate { get; set; }

        public int ItemId { get; set; }

        public Item Item { get; set; }
    }
}