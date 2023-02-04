namespace Vidlyy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addMMbrship1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        id = c.Byte(nullable: false),
                        signUpFee = c.Short(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MembershipTypes");
        }
    }
}
