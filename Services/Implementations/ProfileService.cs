using System.Linq;
using System.Threading.Tasks;
using Ballerz.Data.Models;

namespace Ballerz.Services.Implementations
{
    public class ProfileService : IProfile
    {
       private readonly ApplicationDbContext _db;
        public ProfileService(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task Create(Profile profile)
        {
             _db.Add(profile);
           await _db.SaveChangesAsync();
        }

        public Task Delete(int profileId)
        {
            throw new System.NotImplementedException();
        }

        public Task Edit(int profileId)
        {
            throw new System.NotImplementedException();
        }

        public Profile GetByUserId(string id)
        {
            return _db.Profile.Where(p => p.UserId == id).FirstOrDefault();
        }

        public Profile GetByUserName(string userName)
        {
            return _db.Profile.Where(p => p.UserName == userName).FirstOrDefault();
        }
    }
}