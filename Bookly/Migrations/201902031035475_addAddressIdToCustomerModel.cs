namespace Bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAddressIdToCustomerModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "AddressId", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "AddressId");
        }
    }
}
