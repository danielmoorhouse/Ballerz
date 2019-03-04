using System;
using System.Threading.Tasks;
using Ballerz.Data.Models;
using Ballerz.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ballerz.Controllers
{
    public class LikeController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly INotification _notificationService;

        public LikeController(INotification notificationService, ApplicationDbContext db)
        {
            _notificationService = notificationService;
            _db = db;
        }
                [HttpPost]
        public async Task<string> Toggle(int postId)
        {
            var user = await _db.Users.FirstOrDefaultAsync(u => u.UserName == User.Identity.Name);
            var post = await _db.Posts.FirstOrDefaultAsync(p => p.Id == postId);
            var like = await _db.Likes.FirstOrDefaultAsync(l => l.Post.Id == postId && l.User.UserName == User.Identity.Name);

            if (like == null)
            {
                // Not yet liked, add new like
                var newLike = new Like
                {
                    Post = post,
                    Timestamp = DateTime.Now,
                    User = user
                };

                _db.Likes.Add(newLike);

                var notification = await _notificationService.CreateNotification(post.User.UserName, User.Identity.Name, string.Format("{0} has liked your post.", User.Identity.Name));
                await _notificationService.SendNotification(notification);
            }
            else
            {
                // Already liked post, unlike it
                _db.Likes.Remove(like);
            }

            await _db.SaveChangesAsync();

            return String.Empty;
        }
    }
}