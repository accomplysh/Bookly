namespace Bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeMemberShipTypesFromDB : DbMigration
    {
        public override void Up()
        {
        }
        
        public override void Down()
        {
            Sql("DELETE FROM MembershipTypes where id = 1");
            
        }
    }
}
