namespace InternalTradeMarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingCountries : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Loads", "DepartureCountry", c => c.String(nullable: false));
            AddColumn("dbo.Loads", "ArrivalCountry", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Loads", "ArrivalCountry");
            DropColumn("dbo.Loads", "DepartureCountry");
        }
    }
}
