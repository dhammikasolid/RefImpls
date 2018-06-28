using System.Data.Entity;

namespace Facility.Data
{
    using Domain;

    public class FacilityContext : DbContext
    {
        public FacilityContext() : base("name=FullStack") { }

        public DbSet<Facility> Facilities { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("Facility");
        }
    }
}