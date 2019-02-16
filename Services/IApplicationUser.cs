using Ballerz.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ballerz.Services
{
    public interface IApplicationUser
    {
        Data.Models.ApplicationUser GetById(string id);
        IEnumerable<Data.Models.ApplicationUser> GetAll();

        Task SetProfileImage(string id, Uri uri);
        Task UpdateUserRating(string id, Type type);
    }
}
