namespace InternalTradeMarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovingRequiredFromCountry : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Loads", "DepartureCountry", c => c.String());
            AlterColumn("dbo.Loads", "ArrivalCountry", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Loads", "ArrivalCountry", c => c.String(nullable: false));
            AlterColumn("dbo.Loads", "DepartureCountry", c => c.String(nullable: false));
        }
    }
}
