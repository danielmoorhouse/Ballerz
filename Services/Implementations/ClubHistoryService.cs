using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ballerz.Data;
using Ballerz.Data.Models;
using Ballerz.KnowledgeBase.Models;

namespace Ballerz.Services.Implementations
{
    public class ClubHistoryService : IClubHistory
    {
          private readonly ApplicationDbContext _db;
        public ClubHistoryService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task Create(ClubHistory clubHistory)
        {
            _db.Add(clubHistory);
            await _db.SaveChangesAsync();
        }

        public IEnumerable<ClubHistory> GetAll()
        {
           return _db.ClubHistories.ToList();
        }
    }
}