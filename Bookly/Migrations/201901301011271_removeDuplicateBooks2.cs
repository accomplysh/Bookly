namespace Bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeDuplicateBooks2 : DbMigration
    {
        public override void Up()
        {
            Sql("Delete from books where name = 'Magic of Thinking Big'");
        }
        
        public override void Down()
        {
        }
    }
}
