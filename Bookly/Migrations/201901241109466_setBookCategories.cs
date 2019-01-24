namespace Bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class setBookCategories : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Books SET bookcategory_id = 5");
        }
        
        public override void Down()
        {
        }
    }
}
