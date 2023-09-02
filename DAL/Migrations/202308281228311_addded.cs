namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BookingNotifications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        BookingIdNo = c.Int(nullable: false),
                        IdOfClient = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bookings", t => t.BookingIdNo, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.IdOfClient)
                .Index(t => t.BookingIdNo)
                .Index(t => t.IdOfClient);
            
            CreateTable(
                "dbo.IssueNotifications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        ClientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .Index(t => t.ClientId);
            
            CreateTable(
                "dbo.PaymentNotifications",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        SenderName = c.String(),
                        PaymentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Payments", t => t.PaymentId, cascadeDelete: true)
                .Index(t => t.PaymentId);
            
            AlterColumn("dbo.Issues", "Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PaymentNotifications", "PaymentId", "dbo.Payments");
            DropForeignKey("dbo.IssueNotifications", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.BookingNotifications", "IdOfClient", "dbo.Clients");
            DropForeignKey("dbo.BookingNotifications", "BookingIdNo", "dbo.Bookings");
            DropIndex("dbo.PaymentNotifications", new[] { "PaymentId" });
            DropIndex("dbo.IssueNotifications", new[] { "ClientId" });
            DropIndex("dbo.BookingNotifications", new[] { "IdOfClient" });
            DropIndex("dbo.BookingNotifications", new[] { "BookingIdNo" });
            AlterColumn("dbo.Issues", "Description", c => c.String());
            DropTable("dbo.PaymentNotifications");
            DropTable("dbo.IssueNotifications");
            DropTable("dbo.BookingNotifications");
        }
    }
}
