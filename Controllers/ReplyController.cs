using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Ballerz.Data.Models;
using Ballerz.Services;
using Ballerz.Models.Reply;
using Ballerz.Forums.Models;
using System.Linq;

namespace Ballerz.Controllers
{
    [Authorize]
    public class ReplyController : Controller
    {
         private readonly ApplicationDbContext _db;
        private readonly IPost _postService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IApplicationUser _userService;
        private readonly IProfile _profileService;

        public ReplyController(ApplicationDbContext db, IPost postService, 
            UserManager<ApplicationUser> userManager,
            IApplicationUser userService, IProfile profileService)
        {
            _postService = postService;
            _userManager = userManager;
            _userService = userService;
            _profileService = profileService;
            _db = db;
        }

        public async Task<IActionResult> Create(int id)
        {
            var post = _postService.GetById(id);
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var profile = _db.Profile.Where(p => p.UserName == user.UserName).FirstOrDefault();
            var model = new PostReplyModel
            {
                PostContent = post.Content,
                PostTitle = post.Title,
                PostId = post.Id,

                AuthorId = user.Id,
                AuthorName = User.Identity.Name,
                AuthorImageUrl = profile.ProfileImageUrl,
                AuthorRating = user.Rating,
                IsAuthorAdmin = User.IsInRole("Site Admin"),

                ForumId = post.Forum.Id,
                ForumName = post.Forum.Title,
                ForumImageUrl = post.Forum.ImageUrl,

                Created = DateTime.Now
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddReply(PostReplyModel model)
        {
            var userId = _userManager.GetUserId(User);
            var user = await _userManager.FindByIdAsync(userId);

            var reply = BuildReply(model, user);

            await _postService.AddReply(reply);
            await _userService.UpdateUserRating(userId, typeof(PostReply));

            return RedirectToAction("Index", "Post", new { id = model.PostId });
        }

        private PostReply BuildReply(PostReplyModel model, ApplicationUser user)
        {
            var post = _postService.GetById(model.PostId);

            return new PostReply
            {
                Post = post,
                Content = model.ReplyContent,
                ReplyAuthorImage = model.AuthorImageUrl,
                Created = DateTime.Now,
                User = user
            };
        }
    }
}