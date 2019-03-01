
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

using Ballerz.Data.Models;
using Ballerz.Data;
using Ballerz.Forums.Models;
using Microsoft.EntityFrameworkCore;

namespace Ballerz.Services.Implementations
{
    public class ApplicationUserService : IApplicationUser
    {
        private readonly ApplicationDbContext _db;

        public ApplicationUserService(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Ballerz.Data.Models.ApplicationUser> GetAll()
        {
            return _db.ApplicationUsers;
        }

        public Data.Models.ApplicationUser GetById(string id)
        {
            return GetAll().FirstOrDefault(
                user => user.Id == id);
        }

        public async Task UpdateUserRating(string userId, Type type)
        {
            var user = GetById(userId);
            user.Rating = CalculateUserRating(type, user.Rating);
            await _db.SaveChangesAsync();
        }

        private int CalculateUserRating(Type type, int userRating)
        {
            var inc = 0;

            if (type == typeof(Post))
                inc = 1;

            if (type == typeof(PostReply))
                inc = 3;

            return userRating + inc;
        }

        public async Task SetProfileImage(string id, Uri uri)
        {
            var user = GetById(id);
            user.ProfileImageUrl = uri.AbsoluteUri;
            _db.Update(user);
            await _db.SaveChangesAsync();
        }



        IEnumerable<Data.Models.ApplicationUser> IApplicationUser.GetAll()
        {
            return _db.ApplicationUsers.ToList();
        }

        public async Task<ApplicationUser> GetByUsername(string userName)
        {
            return await _db.ApplicationUsers.FirstOrDefaultAsync(u => u.UserName == userName);
        }

        public async Task<ApplicationUser> GetByUsernameOrId(string userName)
        {
            return await _db.ApplicationUsers.FirstOrDefaultAsync(u => u.UserName == userName || u.Id == userName);
        }
    }
}
