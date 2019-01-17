namespace Bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedBookStatusModel : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.BookStatus", name: "BookId_Id", newName: "Book_Id");
            RenameColumn(table: "dbo.BookStatus", name: "CustomerId_Id", newName: "Customer_Id");
            RenameIndex(table: "dbo.BookStatus", name: "IX_BookId_Id", newName: "IX_Book_Id");
            RenameIndex(table: "dbo.BookStatus", name: "IX_CustomerId_Id", newName: "IX_Customer_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.BookStatus", name: "IX_Customer_Id", newName: "IX_CustomerId_Id");
            RenameIndex(table: "dbo.BookStatus", name: "IX_Book_Id", newName: "IX_BookId_Id");
            RenameColumn(table: "dbo.BookStatus", name: "Customer_Id", newName: "CustomerId_Id");
            RenameColumn(table: "dbo.BookStatus", name: "Book_Id", newName: "BookId_Id");
        }
    }
}
