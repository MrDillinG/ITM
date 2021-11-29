namespace InternalTradeMarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveRequiredFromUserName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Loads", "UserName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Loads", "UserName", c => c.String(nullable: false));
        }
    }
}
