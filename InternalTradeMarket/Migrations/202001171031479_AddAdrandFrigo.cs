namespace InternalTradeMarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAdrandFrigo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Loads", "Frigo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Loads", "Adr", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Loads", "Adr");
            DropColumn("dbo.Loads", "Frigo");
        }
    }
}
