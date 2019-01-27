namespace Bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addBookStatuses : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO BookStatus(Book_Id, Customer_Id) VALUES('1','1')");
            Sql("INSERT INTO BookStatus(Book_Id, Customer_Id) VALUES('2','1')");
        }
        
        public override void Down()
        {
        }
    }
}
