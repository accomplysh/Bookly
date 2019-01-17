namespace Bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addMoreMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes(Id, Fee, DurationInMonths) VALUES(4, 20, 4)");
            Sql("INSERT INTO MembershipTypes(Id, Fee, DurationInMonths) VALUES(5, 28, 5)");
            Sql("INSERT INTO MembershipTypes(Id, Fee, DurationInMonths) VALUES(6, 33, 6)");
        }
        
        public override void Down()
        {
        }
    }
}
