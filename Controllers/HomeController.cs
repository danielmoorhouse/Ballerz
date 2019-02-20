using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ballerz.Models;
using Microsoft.AspNetCore.Identity;
using Ballerz.Data.Models;
using Ballerz.Services; 
using Ballerz.Models.Home;
using Ballerz.Models.Post;
using Ballerz.Models.Forum;
using Ballerz.Forums.Models;
using Ballerz.Models.Profile;
using Ballerz.Models.Teams;

namespace Ballerz.Controllers
{
    public class HomeController : Controller
    {
       // private readonly UserManager<ApplicationUser> _userManager;

          private readonly IPost _postService;
          private readonly IApplicationUser _userService;
          private readonly ITeam _teamService;
          private readonly ApplicationDbContext _db;

        public HomeController(IPost postService, IApplicationUser userService, ApplicationDbContext db, ITeam teamService)
        {
            _postService = postService;
            _userService = userService;
            _db = db;
            _teamService = teamService;
        }

        public IActionResult Index()
        {
            var model = BuildHomeIndexModel();
            return View(model);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private HomeIndexModel BuildHomeIndexModel()
        {
            var latestPosts = _postService.GetLatestPosts(10);

            var users = (from u in _db.Profile.ToList().Take(10)
                        .OrderByDescending(m => m.MemberSince)
                        join c in _db.Countries on u.CountryId equals c.Id
                        join t in _db.Teams on u.TeamId equals t.Id
                        select new ProfileListModel {
                           UserId =  u.UserId,
                              UserName = u.UserName,
                               Location = u.Location, 
                              ProfileImageUrl = u.ProfileImageUrl,
                               MemberSince =  u.MemberSince, 
                               FlagUrl =  c.FlagUrl,
                               TeamBadge = t.TeamBadgeUrl
                                 });
                       
         

            var posts = latestPosts.Select(post => new PostListingModel
            {
                Id = post.Id,
                Title = post.Title,
                AuthorName = post.User.UserName,
                AuthorId = post.User.Id,
                AuthorRating = post.User.Rating,
                DatePosted = post.Created.ToString(),
                RepliesCount = post.Replies.Count(),
                Forum = GetForumListingForPost(post)
            });
            var teams =  _teamService.GetAll().Take(10)
                        .OrderByDescending(r => r.WorldwideFans)
                        .Select(c => new TeamListingModel
                        {
                            TeamName = c.TeamName,
                            TeamBadgeUrl = c.TeamBadgeUrl,
                            WorldwideFans = c.WorldwideFans
                        });

            return new HomeIndexModel
            {
                LatestPosts = posts,
                SearchQuery = "",
                Profile = users,
                Teams = teams
                //UserName = users
                
            };
        }
        private ForumListingModel GetForumListingForPost(Post post)
        {
            var forum = post.Forum;

            return new ForumListingModel
            {
                Id = forum.Id,
                Name = forum.Title,
                ImageUrl = forum.ImageUrl
            };
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
