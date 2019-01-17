namespace Bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedBookCustomerRelationship : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Customer_Id", c => c.Int());
            AddColumn("dbo.Customers", "BookId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Books", "Customer_Id");
            AddForeignKey("dbo.Books", "Customer_Id", "dbo.Customers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.Books", new[] { "Customer_Id" });
            DropColumn("dbo.Customers", "BookId");
            DropColumn("dbo.Books", "Customer_Id");
        }
    }
}
