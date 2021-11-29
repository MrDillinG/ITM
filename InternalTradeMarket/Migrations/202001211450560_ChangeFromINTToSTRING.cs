namespace InternalTradeMarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeFromINTToSTRING : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Loads", "DepartureZipCode", c => c.String(nullable: false));
            AlterColumn("dbo.Loads", "ArrivalZipCode", c => c.String(nullable: false));
            AlterColumn("dbo.Loads", "DeliveryDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Loads", "LoadingMeter", c => c.String(nullable: false));
            AlterColumn("dbo.Loads", "DepartureCountry", c => c.String(nullable: false));
            AlterColumn("dbo.Loads", "ArrivalCountry", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Loads", "ArrivalCountry", c => c.String());
            AlterColumn("dbo.Loads", "DepartureCountry", c => c.String());
            AlterColumn("dbo.Loads", "LoadingMeter", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Loads", "DeliveryDate", c => c.DateTime());
            AlterColumn("dbo.Loads", "ArrivalZipCode", c => c.Int(nullable: false));
            AlterColumn("dbo.Loads", "DepartureZipCode", c => c.Int(nullable: false));
        }
    }
}
