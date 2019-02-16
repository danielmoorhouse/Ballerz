using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ballerz.Data;
using Ballerz.Data.Models;
using Ballerz.KnowledgeBase.Models;

namespace Ballerz.Services.Implementations
{
    public class PlayerService : IPlayer
    {
             private readonly ApplicationDbContext _db;
        public PlayerService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task Create(Players players)
        {
            _db.Add(players);
           await _db.SaveChangesAsync();
        }

        public async Task Delete(int playersId)
        {
            var player = GetById(playersId);
            _db.Remove(player);
            await _db.SaveChangesAsync();
        }

        public Task Edit(int playersId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Players> GetAll()
        {
            return _db.Players.ToList();
        }

        public IEnumerable<Players> GetByCountryId(int id)
        {
            return _db.Players.Where(c => c.CountryId == id).ToList();
        }

        public Players GetById(int id)
        {
            return _db.Players.Where(p => p.Id == id).FirstOrDefault();
        }

        public IEnumerable<Players> GetByTeamId(int id)
        {
           return _db.Players.Where(c => c.TeamId == id).ToList();
        }
    }
}