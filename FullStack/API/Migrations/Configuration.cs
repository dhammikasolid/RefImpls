namespace API.Migrations
{
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<API.ValuesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(API.ValuesContext context)
        {
            context.Values.AddOrUpdate(
                x => x.P1, 
                new Value { P1 = "P11" },
                new Value { P1 = "P12" },
                new Value { P1 = "P13" }
                );

            context.SaveChanges();
        }
    }
}
