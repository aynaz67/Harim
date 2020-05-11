namespace MyFirstApp1399.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCreatedOntoComment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comments", "CreatedOn", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Comments", "CreatedOn");
        }
    }
}
