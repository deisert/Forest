using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forest.Data.Models.Domain;
using Microsoft.Win32;

namespace Forest.Services.IService
{
    public interface IMusicService
    {
        IList<Music> GetMusic(int id);
    }
}
