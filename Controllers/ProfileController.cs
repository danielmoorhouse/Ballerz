using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Net.Http.Headers;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Ballerz.Data.Models;
using Ballerz.Services;
using Ballerz.Models.Profile;
using System.IO;
using Ballerz.Models.Player;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Ballerz.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        private readonly UserManager<Data.Models.ApplicationUser> _userManager;
        private readonly IApplicationUser _userService;
        private readonly IUpload _uploadService;
        private readonly IConfiguration _configuration;
        private readonly IProfile _profileService;
        private readonly ApplicationDbContext _db;

        public ProfileController(
            UserManager<Data.Models.ApplicationUser> userManager, 
            IApplicationUser userService,
            IUpload uploadService,
            IConfiguration configuration,
            IProfile profileService,
            ApplicationDbContext db)
        {
            _userManager = userManager;
            _userService = userService;
            _uploadService = uploadService;
            _configuration = configuration;
            _db = db;
            _profileService = profileService;
        }

        public IActionResult Detail(string id)
        {
               var userTeam = (from User in _db.Profile
                           .Where(p => p.UserId == id)
                              join Team in _db.Teams on User.TeamId equals Team.Id
                              join Country in _db.Countries on User.CountryId equals Country.Id
                              select new { Team.Id,
                                            Team.TeamName, Team.TeamBadgeUrl, Country.Name, Country.FlagUrl })
                              .FirstOrDefault();
            // var userCountry = (from u in _db.Profile
            //                //.Where(p => p.Id == id)
            //                      join Country in _db.Countries on u.CountryId equals Country.Id
            //                      select new { Country.FlagUrl }).FirstOrDefault();
            var user = _userService.GetById(id);
            var profile = _db.Profile.Where(p => p.UserId == id).FirstOrDefault();
            var userRoles = _userManager.GetRolesAsync(user).Result;

            var model = new ProfileDetailModel()
            {
                UserId = profile.UserId,
                FirstName = profile.FirstName,
                LastName = profile.LastName,
                UserName = profile.UserName,
                ShortDescription = profile.ShortDescription,
                TeamId = profile.TeamId,
                TeamName = userTeam.TeamName,
                TeamBadgeUrl = userTeam.TeamBadgeUrl,
                CountryId = profile.CountryId,
                CountryName = userTeam.Name,
                CountryFlagUrl = userTeam.FlagUrl,
                Location = profile.Location,
                IsAdmin = userRoles.Contains("Site Admin"),
                //UserRating = profile.UserRating.ToString(),
                ProfileImageUrl = profile.ProfileImageUrl,
                MemberSince = profile.MemberSince
                
         
            };

            return View(model);
        }

    
                public async Task<IActionResult> Create(int id)
        {

            var user = await _userManager.FindByNameAsync(User.Identity.Name);
             var model = new AddProfileModel();
            {
           
            var teams = _db.Teams.OrderBy(c => c.TeamName)
                                        .Select(x => new { Id = x.Id, Value = x.TeamName });
            model.TeamList = new SelectList(teams, "Id", "Value");

            var countries = _db.Countries.OrderBy(c => c.Name)
                                       .Select(x => new { Id = x.Id, Value = x.Name });

            model.CountryList = new SelectList(countries, "Id", "Value");
            

            model.UserId = user.Id;

            }
        

            return View(model);

        }
        [HttpPost]
        public async Task<IActionResult> AddProfile(AddProfileModel model, IFormCollection image1)
        {
         
             var userId = _userManager.GetUserId(User);

            var user = _userManager.FindByIdAsync(userId).Result;
            string storePath = "/images/profile/";
            var path = Path.Combine(
                     Directory.GetCurrentDirectory(), "wwwroot", "images", "profile",
                     image1.Files[0].FileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await image1.Files[0].CopyToAsync(stream);

            }
            var profile = new Profile
            {
                Id = model.Id,
                UserName = model.UserName,
                UserId = model.UserId,
                FirstName = model.FirstName,
                LastName = model.LastName,
                TeamId = model.TeamId,
                ShortDescription = model.ShortDescription,
                CountryId = model.CountryId,
                Location = model.Location,
                MemberSince = DateTime.Now,
                ProfileImageUrl = storePath + model.ImageUpload.FileName
          


            };
            await _profileService.Create(profile);
             return RedirectToAction("Detail", "Profile", new { id = userId });

        }

        //[Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            var profiles = _userService.GetAll()
                .OrderByDescending(user => user.Rating)
                .Select(u => new ProfileListModel
                {
                    Id = u.Id,
                    FirstName = u.LastName,
                    ProfileImageUrl = u.ProfileImageUrl,
                    UserRating = u.Rating.ToString(),
                    MemberSince = u.MemberSince
                });

            var model = new ProfileIndexModel
            {
                Profiles = profiles
            };

            return View(model);
        }
    }
}