namespace Bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class foreignKeyInBookModelforBookCategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "BookCategoryId", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "BookCategoryId");
        }
    }
}
