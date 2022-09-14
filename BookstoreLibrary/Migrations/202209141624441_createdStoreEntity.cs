namespace BookstoreLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdStoreEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Stores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Latitude = c.Double(nullable: false),
                        Longitude = c.Double(nullable: false),
                        OpeningHour = c.String(),
                        ClosingHour = c.String(),
                        OpeningDays = c.String(),
                        Address_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.Address_Id)
                .Index(t => t.Address_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stores", "Address_Id", "dbo.Addresses");
            DropIndex("dbo.Stores", new[] { "Address_Id" });
            DropTable("dbo.Stores");
        }
    }
}
