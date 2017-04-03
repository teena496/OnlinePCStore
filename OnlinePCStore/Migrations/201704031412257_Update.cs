namespace OnlinePCStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "UserId", c => c.Int(nullable: false));
            DropColumn("dbo.Customers", "Name");
            DropColumn("dbo.Customers", "Email");
            DropColumn("dbo.Customers", "Password");
            DropColumn("dbo.Customers", "ConfirmPassword");
            DropTable("dbo.Orders");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        Mobile = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "ConfirmPassword", c => c.String());
            AddColumn("dbo.Customers", "Password", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.Customers", "Email", c => c.String(nullable: false));
            AddColumn("dbo.Customers", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Customers", "UserId");
        }
    }
}
