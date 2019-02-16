using System.Collections.Generic;
using System.Threading.Tasks;
using Ballerz.KnowledgeBase.Models;

namespace Ballerz.Services
{
    public interface IStadium
    {
         Stadiums GetById(int id);
         Stadiums GetByTeamId(int id);
         IEnumerable<Stadiums> GetAll(); 
         Task<Stadiums> GetByCountryName(string countryName);
         Task Create(Stadiums stadiums);
         Task Edit(int stadiumsId);
         Task Delete(int stadiumsId); 
    }
}