using Forest.Data.Models.Domain;
using System;

namespace Forest.Data.Repository
{
    public class ForestInitialiser : System.Data.Entity.DropCreateDatabaseIfModelChanges<ForestContext>

    {
        protected override void Seed(ForestContext context)
        {
            Genre genre1 = new Genre() { Name = "Rock" };
            Genre genre2 = new Genre() { Name = "Pop" };
            Genre genre3 = new Genre() { Name = "Country" };
            context.Genres.Add(genre1);
            context.Genres.Add(genre2);
            context.Genres.Add(genre3);

            //Tryout to fill the database with some music
            Music music1 = new Music()
            {
                Title = "Sabbath Bloody Sabbath",
                num_track = 6,
                duration = 60,
                DateReleased = Convert.ToDateTime("12/11/1979"),
                Price = 2.50
            };

            Music music2 = new Music()
            {
                Title = "MusicTitle2",
                num_track = 2,
                duration = 60,
                DateReleased = Convert.ToDateTime("12/11/1979"),
                Price = 5.00
            };

            Music music3 = new Music()
            {
                Title = "MusicTitle3",
                num_track = 3,
                duration = 60,
                DateReleased = Convert.ToDateTime("12/11/1979"),
                Price = 7.50
            };
            context.Musics.Add(music1);
            context.Musics.Add(music2);
            context.Musics.Add(music3);
        }
    }
}