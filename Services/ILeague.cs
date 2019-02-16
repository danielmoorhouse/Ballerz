using System.Collections.Generic;
using System.Threading.Tasks;
using Ballerz.KnowledgeBase.Models;

namespace Ballerz.Services
{
    public interface ILeague
    {
         Leagues GetById(int id);
         IEnumerable<Leagues> GetAll(); 
         Task<Leagues> GetByLeagueName(string leagueName);
         List<Leagues> GetByCountryId(int id);
         Task Create(Leagues leagues);
         Task Edit(int leaguesId);
         Task Delete(int leaguesId); 
    }
}