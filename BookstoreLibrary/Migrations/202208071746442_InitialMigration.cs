namespace BookstoreLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Street = c.String(),
                        Number = c.String(),
                        City = c.String(),
                        PostalCode = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Author = c.String(),
                        Type = c.String(),
                        Publisher = c.String(),
                        PublishYear = c.Int(nullable: false),
                        PageNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BookToBorrows",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        Book_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.Book_Id)
                .Index(t => t.Book_Id);
            
            CreateTable(
                "dbo.BookToSells",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Single(nullable: false),
                        Currency = c.String(),
                        Quantity = c.Int(nullable: false),
                        Book_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.Book_Id)
                .Index(t => t.Book_Id);
            
            CreateTable(
                "dbo.BorrowedBooks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BorrowedDate = c.DateTime(nullable: false),
                        DeadlineDate = c.DateTime(nullable: false),
                        Book_Id = c.Int(),
                        BorrowedBy_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BookToBorrows", t => t.Book_Id)
                .ForeignKey("dbo.Users", t => t.BorrowedBy_Id)
                .Index(t => t.Book_Id)
                .Index(t => t.BorrowedBy_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        JoinDate = c.DateTime(nullable: false),
                        AccountBalance = c.Single(nullable: false),
                        Address_Id = c.Int(),
                        Role_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.Address_Id)
                .ForeignKey("dbo.Roles", t => t.Role_Id)
                .Index(t => t.Address_Id)
                .Index(t => t.Role_Id);
            
            CreateTable(
                "dbo.Histories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Action = c.String(),
                        ActionDate = c.DateTime(nullable: false),
                        Book_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.Book_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.Book_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsAdmin = c.Boolean(nullable: false),
                        IsUser = c.Boolean(nullable: false),
                        IsSeller = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SoldBooks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SoldDate = c.DateTime(nullable: false),
                        isShipped = c.Boolean(nullable: false),
                        Book_Id = c.Int(),
                        Buyer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BookToSells", t => t.Book_Id)
                .ForeignKey("dbo.Users", t => t.Buyer_Id)
                .Index(t => t.Book_Id)
                .Index(t => t.Buyer_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SoldBooks", "Buyer_Id", "dbo.Users");
            DropForeignKey("dbo.SoldBooks", "Book_Id", "dbo.BookToSells");
            DropForeignKey("dbo.BorrowedBooks", "BorrowedBy_Id", "dbo.Users");
            DropForeignKey("dbo.Users", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.Histories", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Histories", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.Users", "Address_Id", "dbo.Addresses");
            DropForeignKey("dbo.BorrowedBooks", "Book_Id", "dbo.BookToBorrows");
            DropForeignKey("dbo.BookToSells", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.BookToBorrows", "Book_Id", "dbo.Books");
            DropIndex("dbo.SoldBooks", new[] { "Buyer_Id" });
            DropIndex("dbo.SoldBooks", new[] { "Book_Id" });
            DropIndex("dbo.Histories", new[] { "User_Id" });
            DropIndex("dbo.Histories", new[] { "Book_Id" });
            DropIndex("dbo.Users", new[] { "Role_Id" });
            DropIndex("dbo.Users", new[] { "Address_Id" });
            DropIndex("dbo.BorrowedBooks", new[] { "BorrowedBy_Id" });
            DropIndex("dbo.BorrowedBooks", new[] { "Book_Id" });
            DropIndex("dbo.BookToSells", new[] { "Book_Id" });
            DropIndex("dbo.BookToBorrows", new[] { "Book_Id" });
            DropTable("dbo.SoldBooks");
            DropTable("dbo.Roles");
            DropTable("dbo.Histories");
            DropTable("dbo.Users");
            DropTable("dbo.BorrowedBooks");
            DropTable("dbo.BookToSells");
            DropTable("dbo.BookToBorrows");
            DropTable("dbo.Books");
            DropTable("dbo.Addresses");
        }
    }
}
