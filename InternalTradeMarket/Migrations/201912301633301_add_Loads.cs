namespace InternalTradeMarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_Loads : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Loads",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartureCity = c.String(nullable: false),
                        DepartureZipCode = c.Int(nullable: false),
                        ArrivalCity = c.String(nullable: false),
                        ArrivalZipCode = c.Int(nullable: false),
                        PickupDate = c.DateTime(nullable: false),
                        DeliveryDate = c.DateTime(nullable: false),
                        Weight = c.Int(nullable: false),
                        LoadingMeter = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Loads");
        }
    }
}
