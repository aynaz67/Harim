namespace MyFirstApp1399.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intialcreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MenueId = c.Int(nullable: false),
                        Name = c.String(),
                        Email = c.String(),
                        Opinion = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Menues", t => t.MenueId, cascadeDelete: true)
                .Index(t => t.MenueId);
            
            CreateTable(
                "dbo.Menues",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ParentId = c.Int(nullable: false),
                        Title = c.String(),
                        Text = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Files",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Text = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        FileName = c.String(),
                        FileType = c.String(),
                        Size = c.Int(nullable: false),
                        MenueId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Menues", t => t.MenueId, cascadeDelete: true)
                .Index(t => t.MenueId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Files", "MenueId", "dbo.Menues");
            DropForeignKey("dbo.Comments", "MenueId", "dbo.Menues");
            DropIndex("dbo.Files", new[] { "MenueId" });
            DropIndex("dbo.Comments", new[] { "MenueId" });
            DropTable("dbo.Files");
            DropTable("dbo.Menues");
            DropTable("dbo.Comments");
        }
    }
}
