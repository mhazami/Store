namespace Store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_FooterSlider : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FooterSliders", "FIleId", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.FooterSliders", "FIleId");
        }
    }
}
