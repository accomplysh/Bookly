namespace Bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateBookAndCustomerModel2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Books", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.Books", new[] { "Customer_Id" });
            DropColumn("dbo.Books", "Customer_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "Customer_Id", c => c.Int());
            CreateIndex("dbo.Books", "Customer_Id");
            AddForeignKey("dbo.Books", "Customer_Id", "dbo.Customers", "Id");
        }
    }
}
