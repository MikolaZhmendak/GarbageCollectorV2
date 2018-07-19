namespace GarbageCollectorV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Budgets",
                c => new
                    {
                        BudgetId = c.Int(nullable: false, identity: true),
                        Month = c.String(),
                        AmountOwned = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BudgetId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Budgets");
        }
    }
}
