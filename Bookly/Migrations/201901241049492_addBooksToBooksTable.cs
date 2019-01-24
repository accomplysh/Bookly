namespace Bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addBooksToBooksTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO books(Name,yearpublished,Author,Publisher,ISBN) Values('Grit','2016','Angela Duckworth','Collins','9781443442312')");
            Sql("INSERT INTO books(Name,yearpublished,Author,Publisher,ISBN) Values('The Magic of Thinking Big','1987', 'David J. Schwartz','Touchstone','9780671646783')");
        }
        
        public override void Down()
        {
        }
    }
}
