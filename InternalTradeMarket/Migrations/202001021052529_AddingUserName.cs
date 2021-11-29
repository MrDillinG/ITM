namespace InternalTradeMarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingUserName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Loads", "UserName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Loads", "UserName");
        }
    }
}
