namespace Bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addBookCategoriesToDB : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO BookCategories(Name) Values('Biography')");
            Sql("INSERT INTO BookCategories(Name) Values('Business')");
            Sql("INSERT INTO BookCategories(Name) Values('Science')");
            Sql("INSERT INTO BookCategories(Name) Values('Sports')");
            Sql("INSERT INTO BookCategories(Name) Values('Self Development')");
            Sql("INSERT INTO BookCategories(Name) Values('Religion')");
            Sql("INSERT INTO BookCategories(Name) Values('Programming')");
            Sql("INSERT INTO BookCategories(Name) Values('Design')");
            Sql("INSERT INTO BookCategories(Name) Values('Travel')");
            Sql("INSERT INTO BookCategories(Name) Values('Literature')");
        }
     
        
        public override void Down()
        {
        }
    }
}
