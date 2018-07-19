namespace GarbageCollectorV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialmigration : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.DayPickUps", "TodayPickUpId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DayPickUps", "TodayPickUpId", c => c.Int(nullable: false));
        }
    }
}
