namespace Bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedBookIDFromCustomerModel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "BookId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "BookId", c => c.Byte(nullable: false));
        }
    }
}
