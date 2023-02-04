namespace Vidlyy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateMovies1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Movies", name: "GenreId", newName: "Genre_Id");
            RenameIndex(table: "dbo.Movies", name: "IX_GenreId", newName: "IX_Genre_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Movies", name: "IX_Genre_Id", newName: "IX_GenreId");
            RenameColumn(table: "dbo.Movies", name: "Genre_Id", newName: "GenreId");
        }
    }
}
