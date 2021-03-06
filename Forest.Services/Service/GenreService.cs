using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forest.Data.DAO;
using Forest.Data.IDAO;
using Forest.Data.Models.Domain;
using Forest.Data.Repository;
using Forest.Services.IService;

namespace Forest.Services.Service
{
    public class GenreService : IGenreService
    {
        private IGenreDAO genreDAO; 

        public GenreService()
        {
            genreDAO = new GenreDAO(); 
        }

        public IList<Genre> GetGenres()
        {
            using (var context = new ForestContext())
            {
                return genreDAO.GetGenres(context);
            }
            //return genreDAO.GetGenres();
        }

      /*  public Genre GetGenre(int id)
        {
            //return object 
        }*/
    }
}
