namespace GarbageCollectorV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        StreetAddress = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Zip = c.String(),
                        PhoneNumber = c.String(),
                        HasPaid = c.Boolean(nullable: false),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.CustomerId)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        PaymentId = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        AmountDue = c.Single(nullable: false),
                        PaymentMade = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PaymentId)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        ScheduleId = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        PickUpDay = c.String(),
                        PickUpFrequency = c.String(),
                        StopDate = c.DateTime(),
                        RestartDate = c.DateTime(),
                        ExtraPickUp = c.DateTime(),
                    })
                .PrimaryKey(t => t.ScheduleId)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Schedules", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Payments", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Customers", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Schedules", new[] { "CustomerId" });
            DropIndex("dbo.Payments", new[] { "CustomerId" });
            DropIndex("dbo.Customers", new[] { "User_Id" });
            DropTable("dbo.Schedules");
            DropTable("dbo.Payments");
            DropTable("dbo.Customers");
        }
    }
}
