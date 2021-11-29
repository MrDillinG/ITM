namespace InternalTradeMarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeLDMToDecimal : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Loads", "LoadingMeter", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Loads", "LoadingMeter", c => c.Byte(nullable: false));
        }
    }
}
