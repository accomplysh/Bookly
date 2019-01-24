namespace Bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateMembershipTypesTable : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes set Name = '1 Month' Where Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
