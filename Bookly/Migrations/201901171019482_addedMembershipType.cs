namespace Bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedMembershipType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Fee = c.Int(nullable: false),
                        DurationInMonths = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);

            Sql("INSERT INTO MembershipTypes(Id, Fee, DurationInMonths) VALUES(1, 5, 1)");
            Sql("INSERT INTO MembershipTypes(Id, Fee, DurationInMonths) VALUES(2, 9, 2)");
            Sql("INSERT INTO MembershipTypes(Id, Fee, DurationInMonths) VALUES(3, 13, 3)");

        }
        
        public override void Down()
        {
            DropTable("dbo.MembershipTypes");
        }
    }
}
