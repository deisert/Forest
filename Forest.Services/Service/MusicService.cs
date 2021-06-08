using Forest.Data.DAO;
using Forest.Data.IDAO;
using Forest.Data.Models.Domain;
using Forest.Services.IService;
using System.Collections.Generic;

namespace Forest.Services.Service
{
    public class MusicService : IMusicService
    {
        private IMusicDAO musicDAO;

        public MusicService()
        {
            musicDAO = new MusicDAO();
        }

        public IList<Music> GetMusic(int id)
        {
            return musicDAO.GetMusic(id);
        }
    }
}