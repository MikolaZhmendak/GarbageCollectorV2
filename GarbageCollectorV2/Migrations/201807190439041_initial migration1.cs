namespace GarbageCollectorV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialmigration1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.DayPickUps", "PhoneNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DayPickUps", "PhoneNumber", c => c.String());
        }
    }
}
