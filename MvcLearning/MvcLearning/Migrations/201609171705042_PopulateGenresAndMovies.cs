namespace MvcLearning.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresAndMovies : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Genres (Id,Name) Values(1,'Comedy')");
            Sql("insert into Genres (Id,Name) Values(2,'Family')");
            Sql("insert into Genres (Id,Name) Values(3,'Action')");
            Sql("insert into Genres (Id,Name) Values(4,'Romance')");

            Sql("insert into Movies (Name,ReleaseDate,DateAdded,GenreId) Values('Titanic','01-01-1998','01-01-2016',4)");
            Sql("insert into Movies (Name,ReleaseDate,DateAdded,GenreId) Values('Hangover','01-01-2005','01-01-2016',1)");
            Sql("insert into Movies (Name,ReleaseDate,DateAdded,GenreId) Values('Die Hard','01-01-2005','01-01-2016',3)");
            Sql("insert into Movies (Name,ReleaseDate,DateAdded,GenreId) Values('The Terminator','01-01-2005','01-01-2016',3)");
            Sql("insert into Movies (Name,ReleaseDate,DateAdded,GenreId) Values('Toy Story','01-01-2002','01-01-2015',2)");
        }
        
        public override void Down()
        {
        }
    }
}
