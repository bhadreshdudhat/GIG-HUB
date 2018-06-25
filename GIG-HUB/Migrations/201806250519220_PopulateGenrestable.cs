namespace GIG_HUB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenrestable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id,Name) VALUES (1, 'Jazz')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (2, 'Blue')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (3, 'Rock')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (4, 'Country')");
        }

       //in code-first data flow it is possible to take database to any versions
       //on update-datbase by-default it goes to last migration
       //so when modifying the up method it's good practice to modify Down() method
       //to put database in the right state
       //UP() is opposite of Down()
        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id IN (1,2,3,4)");
        }
    }
}
