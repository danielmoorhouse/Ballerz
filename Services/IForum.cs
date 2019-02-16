
using System.Collections.Generic;
using System.Threading.Tasks;
using Ballerz.Forums.Models;

namespace Ballerz.Services
{
    public interface IForum
    {
        Forum GetById(int id);
        IEnumerable<Forum> GetAll();

        Task Create(Forum forum);
        Task Delete(int forumId);
        Task UpdateForumTitle(int forumId, string newTitle);
        Task UpdateForumDescription(int forumId, string newDescription);
        IEnumerable<Data.Models.ApplicationUser> GetActiveUsers(int id);
        bool HasRecentPost(int id);
    }
}
