namespace InternalTradeMarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixingMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Loads", "Lat", c => c.Int(nullable: false));
            AddColumn("dbo.Loads", "Long", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Loads", "Long");
            DropColumn("dbo.Loads", "Lat");
        }
    }
}
