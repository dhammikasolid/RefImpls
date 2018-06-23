namespace API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddValuesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Values",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        P1 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Values");
        }
    }
}
