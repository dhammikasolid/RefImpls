using System.Data.Common;
using System.Data.Entity;

namespace API.Customers
{
    public class CustomerContext : DbContext
    {
        public CustomerContext() : base("name=FullStack") { }

        public CustomerContext(DbConnection con) : base(existingConnection: con, contextOwnsConnection: false) { }

        public DbSet<Customer> Customers { get; set; }
    }
}