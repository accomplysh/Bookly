namespace Bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeAddressIdPropertyFromCustomerModel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "AddressId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "AddressId", c => c.Byte(nullable: false));
        }
    }
}
