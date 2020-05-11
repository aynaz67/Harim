namespace MyFirstApp1399.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fix_Typo : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Menues", newName: "Menus");
            RenameColumn(table: "dbo.Comments", name: "MenueId", newName: "MenuId");
            RenameColumn(table: "dbo.Files", name: "MenueId", newName: "MenuId");
            RenameIndex(table: "dbo.Comments", name: "IX_MenueId", newName: "IX_MenuId");
            RenameIndex(table: "dbo.Files", name: "IX_MenueId", newName: "IX_MenuId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Files", name: "IX_MenuId", newName: "IX_MenueId");
            RenameIndex(table: "dbo.Comments", name: "IX_MenuId", newName: "IX_MenueId");
            RenameColumn(table: "dbo.Files", name: "MenuId", newName: "MenueId");
            RenameColumn(table: "dbo.Comments", name: "MenuId", newName: "MenueId");
            RenameTable(name: "dbo.Menus", newName: "Menues");
        }
    }
}
