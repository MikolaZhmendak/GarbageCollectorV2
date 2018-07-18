namespace GarbageCollectorV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstmigrationagian : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employers",
                c => new
                    {
                        EmployerId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.EmployerId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employers");
        }
    }
}
