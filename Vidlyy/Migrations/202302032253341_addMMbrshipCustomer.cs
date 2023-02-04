namespace Vidlyy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addMMbrshipCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "MembershipId", c => c.Byte(nullable: false));
            AddColumn("dbo.Customers", "MembershipType_id", c => c.Byte());
            CreateIndex("dbo.Customers", "MembershipType_id");
            AddForeignKey("dbo.Customers", "MembershipType_id", "dbo.MembershipTypes", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MembershipType_id", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "MembershipType_id" });
            DropColumn("dbo.Customers", "MembershipType_id");
            DropColumn("dbo.Customers", "MembershipId");
        }
    }
}
