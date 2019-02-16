using System.Threading.Tasks;
using Ballerz.Data.Models;

namespace Ballerz.Services
{
    public interface IProfile
    {
        Data.Models.Profile GetByUserId(string id); 

        Profile GetByUserName(string userName);

         Task Create(Profile profile);
         Task Edit(int profileId);
         Task Delete(int profileId);
    }
}