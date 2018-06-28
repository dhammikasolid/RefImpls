namespace Facility.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Facility.Facilities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Facility.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Facility.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        From = c.DateTime(nullable: false),
                        To = c.DateTime(nullable: false),
                        FacilityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Facility.Facilities", t => t.FacilityId, cascadeDelete: true)
                .Index(t => t.FacilityId);
            
            CreateTable(
                "Facility.ReservationDates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsFullDay = c.Boolean(nullable: false),
                        From = c.DateTime(nullable: false),
                        To = c.DateTime(nullable: false),
                        ReservationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Facility.Reservations", t => t.ReservationId, cascadeDelete: true)
                .Index(t => t.ReservationId);
            
            CreateTable(
                "Facility.ReservationItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quatity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ReservationDateId = c.Int(nullable: false),
                        ItemId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Facility.Items", t => t.ItemId, cascadeDelete: true)
                .ForeignKey("Facility.ReservationDates", t => t.ReservationDateId, cascadeDelete: true)
                .Index(t => t.ReservationDateId)
                .Index(t => t.ItemId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Facility.Reservations", "FacilityId", "Facility.Facilities");
            DropForeignKey("Facility.ReservationItems", "ReservationDateId", "Facility.ReservationDates");
            DropForeignKey("Facility.ReservationItems", "ItemId", "Facility.Items");
            DropForeignKey("Facility.ReservationDates", "ReservationId", "Facility.Reservations");
            DropIndex("Facility.ReservationItems", new[] { "ItemId" });
            DropIndex("Facility.ReservationItems", new[] { "ReservationDateId" });
            DropIndex("Facility.ReservationDates", new[] { "ReservationId" });
            DropIndex("Facility.Reservations", new[] { "FacilityId" });
            DropTable("Facility.ReservationItems");
            DropTable("Facility.ReservationDates");
            DropTable("Facility.Reservations");
            DropTable("Facility.Items");
            DropTable("Facility.Facilities");
        }
    }
}
