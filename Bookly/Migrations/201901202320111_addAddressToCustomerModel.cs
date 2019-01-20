namespace Bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAddressToCustomerModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Address_Id", c => c.Int());
            CreateIndex("dbo.Customers", "Address_Id");
            AddForeignKey("dbo.Customers", "Address_Id", "dbo.Addresses", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "Address_Id", "dbo.Addresses");
            DropIndex("dbo.Customers", new[] { "Address_Id" });
            DropColumn("dbo.Customers", "Address_Id");
        }
    }
}
