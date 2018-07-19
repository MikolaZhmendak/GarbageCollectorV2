namespace GarbageCollectorV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TodayPickUps",
                c => new
                    {
                        TodayPickUpId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        StreetAddress = c.String(),
                        ZipCode = c.Int(nullable: false),
                        PickUpDate = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.TodayPickUpId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TodayPickUps");
        }
    }
}
