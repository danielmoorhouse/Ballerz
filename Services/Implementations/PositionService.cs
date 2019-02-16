using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ballerz.Data;
using Ballerz.Data.Models;
using Ballerz.KnowledgeBase.Models;

namespace Ballerz.Services.Implementations
{
    public class PositionService : IPosition
    {
         private readonly ApplicationDbContext _db;
        public PositionService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task Create(Positions positions)
        {
              _db.Add(positions);
            await _db.SaveChangesAsync();
        }

        public IEnumerable<Positions> GetAll()
        {
            return _db.Positions.ToList();
        }

        public Positions GetById(int id)
        {
            return _db.Positions.Where(p => p.PositionId == id).FirstOrDefault();
        }
    }
}