using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ballerz.Data;
using Ballerz.Data.Models;
using Ballerz.KnowledgeBase.Models;

namespace Ballerz.Services.Implementations
{
    public class ManagerService : IManager
    {
           private readonly ApplicationDbContext _db;
        public ManagerService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task Create(Managers managers)
        {
            _db.Add(managers);
           await _db.SaveChangesAsync();
        }

        public async Task Delete(int managersId)
        {
             var managers = GetById(managersId);
            _db.Remove(managers);
            await _db.SaveChangesAsync();
        }

        public Task Edit(int managersId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Managers> GetAll()
        {
            return _db.Managers.ToList();
        }

        public IEnumerable<Managers> GetByCountryId(int id)
        {
            return _db.Managers.Where(c => c.CountryId == id).ToList();

        }

        public Managers GetById(int id)
        {
           var manager = _db.Managers.Where(m => m.Id == id).FirstOrDefault();
            return manager;
        }

        public Managers GetByManagerName(string managerName)
        {
            var manager = _db.Managers.Where(m => m.ManagerName == managerName).FirstOrDefault();
            return manager;
        }

    

        public Managers GetByTeamId(int id)
        {
            var manager = _db.Managers.Where(m => m.TeamId == id).FirstOrDefault();
         return manager;
        }

        // public Managers GetByTeamName(string name)
        // {
        //     return _db.Managers.Where(m => m.TeamName == name).FirstOrDefault();
            
        // }

        public Task SetManagerImage(string id, Uri uri)
        {
            throw new NotImplementedException();
        }

       
    }
}