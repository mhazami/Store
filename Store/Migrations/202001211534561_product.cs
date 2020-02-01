namespace Store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class product : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150),
                        SeleCount = c.Int(nullable: false),
                        isActive = c.Boolean(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SaveDate = c.String(nullable: false, maxLength: 10),
                        SaveTime = c.String(nullable: false, maxLength: 5),
                        Descriptior = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}
