namespace Bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateBookStatus3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BookStatus", "Identifier", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BookStatus", "Identifier");
        }
    }
}
