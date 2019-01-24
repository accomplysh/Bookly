namespace Bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomerDOB : DbMigration
    {
        public override void Up()
        {
            Sql("Update Customers Set DOB = '09/05/1983' WHERE id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
