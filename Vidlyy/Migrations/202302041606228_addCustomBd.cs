namespace Vidlyy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCustomBd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "BirthDate", c => c.String(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "BirthDate");
        }
    }
}
