using System.Collections.Generic;
using System.Threading.Tasks;
using Ballerz.KnowledgeBase.Models;

namespace Ballerz.Services
{
    public interface IClubHistory
    {
       
        Task Create(ClubHistory clubHistory); 
        IEnumerable<ClubHistory> GetAll(); 
    }
}