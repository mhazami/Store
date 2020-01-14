namespace Store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Edit_Slider : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Sliders", "Image_Id", "FileManager.File");
            DropIndex("dbo.Sliders", new[] { "Image_Id" });
            AddColumn("dbo.Sliders", "FileId", c => c.Guid(nullable: false));
            DropColumn("dbo.Sliders", "Image_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sliders", "Image_Id", c => c.Guid());
            DropColumn("dbo.Sliders", "FileId");
            CreateIndex("dbo.Sliders", "Image_Id");
            AddForeignKey("dbo.Sliders", "Image_Id", "FileManager.File", "Id");
        }
    }
}
