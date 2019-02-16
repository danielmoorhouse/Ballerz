using System.Collections.Generic;
using System.Threading.Tasks;
using Ballerz.KnowledgeBase.Models;

namespace Ballerz.Services
{
    public interface IPlayer
    {
         Players GetById(int id);
         IEnumerable<Players> GetByTeamId(int id);
         //Managers GetByTeamName(string name);
         IEnumerable<Players> GetByCountryId(int id);
         IEnumerable<Players> GetAll(); 
         
         Task Create(Players players);
         Task Edit(int playersId);
         Task Delete(int playersId); 
    }
}