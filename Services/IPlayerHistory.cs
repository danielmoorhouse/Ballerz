using System.Collections.Generic;
using System.Threading.Tasks;
using Ballerz.KnowledgeBase.Models;

namespace Ballerz.Services
{
    public interface IPlayerHistory
    {
       Task Create(PlayerHistory playerHistory); 
        IEnumerable<PlayerHistory> GetAll(); 
        // IEnumerable<PlayerHistory> GetAllByPlayerName(string name);  
    }
}