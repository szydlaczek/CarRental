namespace CarRental.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CarReservation",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ReservationDate = c.DateTime(nullable: false),
                        Name = c.String(nullable: false),
                        PhoneNumber = c.String(nullable: false),
                        City = c.String(nullable: false),
                        PostCode = c.String(nullable: false),
                        Street = c.String(nullable: false),
                        CarTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CarType", t => t.CarTypeId, cascadeDelete: true)
                .Index(t => t.CarTypeId);
            
            CreateTable(
                "dbo.CarType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Capacity = c.Int(nullable: false),
                        PassengerCount = c.Int(nullable: false),
                        NumberOfCars = c.Int(nullable: false),
                        DayPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CarReservation", "CarTypeId", "dbo.CarType");
            DropIndex("dbo.CarReservation", new[] { "CarTypeId" });
            DropTable("dbo.CarType");
            DropTable("dbo.CarReservation");
        }
    }
}
