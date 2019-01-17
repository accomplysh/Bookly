namespace Bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedBookStatusModelToContext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BookStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookId_Id = c.Int(),
                        CustomerId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId_Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId_Id)
                .Index(t => t.BookId_Id)
                .Index(t => t.CustomerId_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BookStatus", "CustomerId_Id", "dbo.Customers");
            DropForeignKey("dbo.BookStatus", "BookId_Id", "dbo.Books");
            DropIndex("dbo.BookStatus", new[] { "CustomerId_Id" });
            DropIndex("dbo.BookStatus", new[] { "BookId_Id" });
            DropTable("dbo.BookStatus");
        }
    }
}
