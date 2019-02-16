using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ballerz.Data;
using Ballerz.Data.Models;
using Ballerz.KnowledgeBase.Models;

namespace Ballerz.Services.Implementations
{
    public class LeagueService : ILeague
    {
         private readonly ApplicationDbContext _db;
        public LeagueService(ApplicationDbContext db)
        {
            _db = db;
        }
       
        public async Task Create(Leagues leagues)
        {
            _db.Add(leagues);
            await _db.SaveChangesAsync();
        }

        public Task Delete(int leaguesId)
        {
            throw new System.NotImplementedException();
        }

        public Task Edit(int leaguesId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Leagues> GetAll()
        {
            return _db.Leagues.ToList();
        }

        public List<Leagues> GetByCountryId(int id)
        {
            return _db.Leagues.Where(l => l.CountryId == id).ToList();
        }

        public Leagues GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Leagues> GetByLeagueName(string leagueName)
        {
            throw new System.NotImplementedException();
        }
    }
}