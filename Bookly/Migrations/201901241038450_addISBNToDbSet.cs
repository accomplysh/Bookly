namespace Bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addISBNToDbSet : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "ISBN", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "ISBN");
        }
    }
}
