namespace InternalTradeMarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingExtraComments : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Loads", "ExtraComments", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Loads", "ExtraComments");
        }
    }
}
