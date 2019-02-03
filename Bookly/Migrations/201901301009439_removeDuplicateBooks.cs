namespace Bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeDuplicateBooks : DbMigration
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
