namespace Bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateBooksTable : DbMigration
    {
        public override void Up()
        {
            Sql("update books set ISBN = '978-1585424337', Author = 'Napoleon Hill', Publisher='TarcherPerigee', yearpublished = '2015' where id = 1 ");
        }
        
        public override void Down()
        {
        }
    }
}
