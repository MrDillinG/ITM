namespace InternalTradeMarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTimeDate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Loads", "DeliveryDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Loads", "DeliveryDate", c => c.DateTime(nullable: false));
        }
    }
}
