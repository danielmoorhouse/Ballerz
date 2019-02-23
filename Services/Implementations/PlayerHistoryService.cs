using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ballerz.Data.Models;
using Ballerz.KnowledgeBase.Models;

namespace Ballerz.Services.Implementations
{
    public class PlayerHistoryService : IPlayerHistory
    {
             private readonly ApplicationDbContext _db;
        public PlayerHistoryService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task Create(PlayerHistory playerHistory)
        {
            _db.Add(playerHistory);
            await _db.SaveChangesAsync();
        }

        public IEnumerable<PlayerHistory> GetAll()
        {
           return _db.PlayerHistories.ToList();
        }
        //   public IEnumerable<PlayerHistory> GetAllByPlayerName(string name)
        // {
        //    return _db.PlayerHistories.Where(p => p.PlayerName == name).ToList();
        // }
    }
}