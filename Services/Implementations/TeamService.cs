using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ballerz.Data;
using Ballerz.Data.Models;
using Ballerz.KnowledgeBase.Models;

namespace Ballerz.Services.Implementations
{
    public class TeamService : ITeam
    {
        private readonly ApplicationDbContext _db;
        public TeamService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task Create(Teams teams)
        {
                _db.Add(teams);
            await _db.SaveChangesAsync();
        }

        public Task Delete(int teamsId)
        {
            throw new System.NotImplementedException();
        }

        public Task Edit(int teamsId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Teams> GetAll()
        {
            return _db.Teams.ToList();
        }

        public Teams GetById(int id)
        {
            return _db.Teams.Where(t => t.Id == id).FirstOrDefault();
        }

        public List<Teams> GetByLeagueId(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Teams> GetByTeamName(string teamName)
        {
            throw new System.NotImplementedException();
        }
    }
}