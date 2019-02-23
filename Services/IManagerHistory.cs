using System.Collections.Generic;
using System.Threading.Tasks;
using Ballerz.KnowledgeBase.Models;

namespace Ballerz.Services
{
    public interface IManagerHistory
    {
          Task Create(ManagerHistory managerHistory); 
        IEnumerable<ManagerHistory> GetAll(); 
    }
}