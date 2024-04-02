using Jokee.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokee.Service.IService
{
    public interface IJokeService
    {
        Task<List<Joke>> GetJokees();
    }
}
