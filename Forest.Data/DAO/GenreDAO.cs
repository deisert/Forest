using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Forest.Data.IDAO;
using Forest.Data.Models.Domain;
using Forest.Data.Repository;
using Forest.Data.DAO;

namespace Forest.Data.DAO
{
    public class GenreDAO : IGenreDAO
    {
        private ForestContext context; 

        public GenreDAO()
        {
            context = new ForestContext(); 
        }

        public IList<Genre> GetGenres(ForestContext context)
        {
            return context.Genres.ToList();
        }

        public Genre GetGenre(int id)
        {
            //EagerLoading (Not LazyLoading)
            context.Genres.Include(g => g.Musics).ToList();
            //return GenreObject
            return context.Genres.Find(id);
        }
    }
}
