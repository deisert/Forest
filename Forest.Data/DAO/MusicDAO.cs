using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forest.Data.IDAO;
using Forest.Data.Models.Domain;
using Forest.Data.Repository;
using Forest.Data.DAO;

namespace Forest.Data.DAO
{
    public class MusicDAO : IMusicDAO
    {
        private ForestContext context;

        public MusicDAO()
        {
            context = new ForestContext();
        }

        public IList<Music> GetMusic(int id)
        {
            return context.Musics.ToList();
        }
    }
}
