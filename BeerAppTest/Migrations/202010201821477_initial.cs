namespace BeerAppTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserCredentials",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        UserName = c.String(),
                        EmailAdress = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("dbo.User", t => t.UserID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Location_Counry = c.String(),
                        Location_PostalCode = c.String(),
                        Location_Address = c.String(),
                        Gender = c.Int(nullable: false),
                        LastName = c.String(),
                        FirstName = c.String(),
                        BirtDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserCredentials", "UserID", "dbo.User");
            DropIndex("dbo.UserCredentials", new[] { "UserID" });
            DropTable("dbo.User");
            DropTable("dbo.UserCredentials");
        }
    }
}
