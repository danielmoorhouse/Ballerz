using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ballerz.KnowledgeBase.Models;

namespace Ballerz.Services
{
    public interface IManager
    {
         Managers GetById(int id);
         Managers GetByTeamId(int id);
         //Managers GetByTeamName(string name);
         IEnumerable<Managers> GetByCountryId(int id);
         IEnumerable<Managers> GetAll(); 
         Managers GetByManagerName(string managerName);
         Task Create(Managers managers);
         Task Edit(int managersId);
         Task Delete(int managersId);
         Task SetManagerImage(string id, Uri uri); 
    }
}