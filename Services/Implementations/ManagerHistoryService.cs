using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ballerz.Data.Models;
using Ballerz.KnowledgeBase.Models;

namespace Ballerz.Services.Implementations
{
    public class ManagerHistoryService : IManagerHistory
    {
        private readonly ApplicationDbContext _db;
        public ManagerHistoryService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task Create(ManagerHistory playerHistory)
        {
            _db.Add(playerHistory);
            await _db.SaveChangesAsync();
        }

        public IEnumerable<ManagerHistory> GetAll()
        {
           return _db.ManagerHistories.ToList();
        } 
    }
}