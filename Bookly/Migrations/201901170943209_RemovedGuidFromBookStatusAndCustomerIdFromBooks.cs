namespace Bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedGuidFromBookStatusAndCustomerIdFromBooks : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Books", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.Books", new[] { "Customer_Id" });
            DropColumn("dbo.Books", "Customer_Id");
            DropColumn("dbo.BookStatus", "Identifier");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BookStatus", "Identifier", c => c.Guid(nullable: false));
            AddColumn("dbo.Books", "Customer_Id", c => c.Int());
            CreateIndex("dbo.Books", "Customer_Id");
            AddForeignKey("dbo.Books", "Customer_Id", "dbo.Customers", "Id");
        }
    }
}
