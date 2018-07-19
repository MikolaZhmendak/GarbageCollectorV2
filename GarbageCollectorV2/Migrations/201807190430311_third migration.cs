namespace GarbageCollectorV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thirdmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DayPickUps",
                c => new
                    {
                        DayPickUpId = c.Int(nullable: false, identity: true),
                        TodayPickUpId = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        StreetAddress = c.String(),
                        ZipCode = c.Int(nullable: false),
                        PickUpDate = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.DayPickUpId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DayPickUps");
        }
    }
}
