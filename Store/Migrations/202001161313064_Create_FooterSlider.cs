namespace Store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_FooterSlider : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FooterSliders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Order = c.Byte(nullable: false),
                        Title = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FooterSliders");
        }
    }
}
