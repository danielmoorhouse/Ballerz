using System.Collections.Generic;
using System.Threading.Tasks;
using Ballerz.KnowledgeBase.Models;

namespace Ballerz.Services
{
    public interface ITeam
    {
         Teams GetById(int id);
         IEnumerable<Teams> GetAll(); 
         Task<Teams> GetByTeamName(string teamName);
         List<Teams> GetByLeagueId(int id);
         Task Create(Teams teams);
         Task Edit(int teamsId);
         Task Delete(int teamsId); 
    }
}