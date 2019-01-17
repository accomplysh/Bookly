namespace Bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedBookYearPublished : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "YearPublished", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "YearPublished");
        }
    }
}
