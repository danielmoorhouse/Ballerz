using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ballerz.Data;
using Ballerz.Data.Models;
using Ballerz.KnowledgeBase.Models;

namespace Ballerz.Services.Implementations
{
    public class StadiumService : IStadium
    {
             private readonly ApplicationDbContext _db;
        public StadiumService(ApplicationDbContext db)
        {
            _db = db;
        }
       
        public async Task Create(Stadiums stadiums)
        {
            _db.Add(stadiums);
            await _db.SaveChangesAsync();
        }

        public Task Delete(int stadiumsId)
        {
            throw new System.NotImplementedException();
        }

        public Task Edit(int stadiumsId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Stadiums> GetAll()
        {
            return _db.Stadiums.ToList();
        }

        public Task<Stadiums> GetByCountryName(string countryName)
        {
            throw new System.NotImplementedException();
        }

        public Stadiums GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Stadiums GetByTeamId(int id)
        {
            var stadium = _db.Stadiums.Where(s => s.TeamId == id).FirstOrDefault();
            return stadium;
        }
    }
}