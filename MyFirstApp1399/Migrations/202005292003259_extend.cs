namespace MyFirstApp1399.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class extend : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PostId = c.Int(nullable: false),
                        Name = c.String(),
                        Email = c.String(),
                        Opinion = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Posts", t => t.PostId, cascadeDelete: true)
                .Index(t => t.PostId);
            
            CreateTable(
                "dbo.Files",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PostId = c.Int(nullable: false),
                        Title = c.String(),
                        Text = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        FileName = c.String(),
                        FileType = c.String(),
                        Size = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Posts", t => t.PostId, cascadeDelete: true)
                .Index(t => t.PostId);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ParentId = c.Int(nullable: false),
                        Title = c.String(),
                        Text = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Posts", "MenuId", c => c.Int(nullable: false));
            CreateIndex("dbo.Posts", "MenuId");
            AddForeignKey("dbo.Posts", "MenuId", "dbo.Menus", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "MenuId", "dbo.Menus");
            DropForeignKey("dbo.Files", "PostId", "dbo.Posts");
            DropForeignKey("dbo.Comments", "PostId", "dbo.Posts");
            DropIndex("dbo.Files", new[] { "PostId" });
            DropIndex("dbo.Posts", new[] { "MenuId" });
            DropIndex("dbo.Comments", new[] { "PostId" });
            DropColumn("dbo.Posts", "MenuId");
            DropTable("dbo.Menus");
            DropTable("dbo.Files");
            DropTable("dbo.Comments");
        }
    }
}
