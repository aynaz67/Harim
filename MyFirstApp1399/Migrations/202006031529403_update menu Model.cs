namespace MyFirstApp1399.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatemenuModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Menus", "ParentId", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Menus", "ParentId", c => c.Int(nullable: false));
        }
    }
}
