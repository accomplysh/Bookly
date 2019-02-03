namespace Bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedBackBookCategoryNavigationProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "BookCategory_Id", c => c.Int());
            CreateIndex("dbo.Books", "BookCategory_Id");
            AddForeignKey("dbo.Books", "BookCategory_Id", "dbo.BookCategories", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "BookCategory_Id", "dbo.BookCategories");
            DropIndex("dbo.Books", new[] { "BookCategory_Id" });
            DropColumn("dbo.Books", "BookCategory_Id");
        }
    }
}
