namespace Store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Db : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "FileManager.File",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Extention = c.String(maxLength: 10),
                        Size = c.Int(nullable: false),
                        Content = c.Binary(),
                        Name = c.String(maxLength: 50),
                        ContentType = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sliders",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Title = c.String(),
                        Description = c.String(),
                        Image_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("FileManager.File", t => t.Image_Id)
                .Index(t => t.Image_Id);
            
            CreateTable(
                "Security.User",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 150),
                        Family = c.String(nullable: false, maxLength: 150),
                        Username = c.String(nullable: false, maxLength: 10),
                        Password = c.String(nullable: false, maxLength: 10),
                        CreateDate = c.String(nullable: false, maxLength: 10),
                        CreateTime = c.String(nullable: false, maxLength: 5),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sliders", "Image_Id", "FileManager.File");
            DropIndex("dbo.Sliders", new[] { "Image_Id" });
            DropTable("Security.User");
            DropTable("dbo.Sliders");
            DropTable("FileManager.File");
        }
    }
}
