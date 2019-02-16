using System.Collections.Generic;
using System.Threading.Tasks;
using Ballerz.KnowledgeBase.Models;

namespace Ballerz.Services
{
    public interface IPosition
    {
          Task Create(Positions positions); 
        IEnumerable<Positions> GetAll();
        Positions GetById(int id);
    }
}