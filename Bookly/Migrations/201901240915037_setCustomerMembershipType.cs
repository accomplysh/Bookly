namespace Bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class setCustomerMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("Update Customers Set MembershipType_Id = 2 Where Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
