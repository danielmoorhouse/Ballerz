using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ballerz.KnowledgeBase.Models;

namespace Ballerz.Services
{
    public interface ICountries
    {
         Countries GetById(int id);
         Countries GetCountryName(int id);
         IEnumerable<Countries> GetAll(); 
         Task<Countries> GetByCountryName(string countryName);
         Task Create(Countries countries);
         Task Edit(int countriesId);
         Task Delete(int countriesId);
         Task SetFlagImage(string id, Uri uri);


    }
}