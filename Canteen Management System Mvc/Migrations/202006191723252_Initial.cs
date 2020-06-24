namespace Canteen_Management_System_Mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        ItemId = c.Int(nullable: false, identity: true),
                        ItemName = c.String(),
                        Cost = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ItemId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        ItemId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Total = c.Double(nullable: false),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.OrderId);
            
            CreateTable(
                "dbo.Vendors",
                c => new
                    {
                        VendorId = c.Int(nullable: false, identity: true),
                        VendorName = c.String(),
                        VendorEmail = c.String(),
                    })
                .PrimaryKey(t => t.VendorId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Vendors");
            DropTable("dbo.Orders");
            DropTable("dbo.Menus");
        }
    }
}
