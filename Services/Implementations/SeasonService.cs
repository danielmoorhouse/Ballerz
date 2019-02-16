using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ballerz.Data;
using Ballerz.Data.Models;
using Ballerz.KnowledgeBase.Models;

namespace Ballerz.Services.Implementations
{
    public class SeasonService : ISeason
    {
        private readonly ApplicationDbContext _db;
        public SeasonService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task Create(Seasons seasons)
        {
             _db.Add(seasons);
            await _db.SaveChangesAsync();
        }
        public IEnumerable<Seasons> GetAll()
        {
            return _db.Seasons.ToList();
        }
    }
}