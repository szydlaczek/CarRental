namespace CarRental.Infrastructure.Migrations
{
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
                    Name = c.String(),
                    PhoneNumber = c.String(),
                    City = c.String(),
                    PostCode = c.String(),
                    Street = c.String(),
                    CarTypeEntity_Id = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CarType", t => t.CarTypeEntity_Id, cascadeDelete: true)
                .Index(t => t.CarTypeEntity_Id);

            CreateTable(
                "dbo.CarType",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Capacity = c.Int(nullable: false),
                    PassengerCount = c.Int(nullable: false),
                    NumberOfCars = c.Int(nullable: false),
                    DayPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                })
                .PrimaryKey(t => t.Id);
        }

        public override void Down()
        {
            DropForeignKey("dbo.CarReservation", "CarTypeEntity_Id", "dbo.CarType");
            DropIndex("dbo.CarReservation", new[] { "CarTypeEntity_Id" });
            DropTable("dbo.CarType");
            DropTable("dbo.CarReservation");
        }
    }
}