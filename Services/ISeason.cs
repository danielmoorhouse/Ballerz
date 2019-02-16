using System.Collections.Generic;
using System.Threading.Tasks;
using Ballerz.KnowledgeBase.Models;

namespace Ballerz.Services
{
    public interface ISeason
    {
        Task Create(Seasons seasons); 
        IEnumerable<Seasons> GetAll();
    }
}