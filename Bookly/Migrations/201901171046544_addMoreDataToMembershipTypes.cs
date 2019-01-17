namespace Bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addMoreDataToMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes(Id, Fee, DurationInMonths) VALUES(7, 39, 7)");
            Sql("INSERT INTO MembershipTypes(Id, Fee, DurationInMonths) VALUES(8, 47, 8)");
            Sql("INSERT INTO MembershipTypes(Id, Fee, DurationInMonths) VALUES(0, 55, 9)");
        }
        
        public override void Down()
        {
        }
    }
}
