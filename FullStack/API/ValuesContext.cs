using System.Data.Entity;

namespace API
{
    public class ValuesContext : DbContext
    {
        public ValuesContext() : base("FullStack") { }

        public DbSet<Value> Values { get; set; }

    }
}