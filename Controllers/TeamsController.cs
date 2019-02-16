using System;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Ballerz.Data;
using Ballerz.Data.Models;
using Ballerz.KnowledgeBase.Models;
using Ballerz.Models.Teams;
using Ballerz.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Microsoft.WindowsAzure.Storage.Blob;

namespace Ballerz.Web.Controllers
{
    public class TeamsController : Controller
    {
         private readonly ApplicationDbContext _db;
        private readonly ILeague _leagueService;
        private readonly ITeam _teamService;
         private readonly IUpload _uploadService;
        private readonly IConfiguration _configuration;
         private readonly IHostingEnvironment _environment;
         private readonly IManager _managerService;
         private readonly IStadium _stadiumService;
         private readonly IPlayer _playerService;

        public TeamsController(ApplicationDbContext db, IConfiguration configuration, IUpload uploadService, ILeague leagueService,
                 ITeam teamService,  IHostingEnvironment environment, IManager managerService, IStadium stadiumService, IPlayer playerService)
        {
           _db = db;
           _leagueService = leagueService;
           _uploadService = uploadService;
           _configuration = configuration;
           _teamService = teamService;
           _environment = environment;
           _managerService = managerService;
           _stadiumService = stadiumService;
           _playerService = playerService;
        }
               public IActionResult Index()
        {
            var teams = _teamService.GetAll()
             .OrderBy(team => team.TeamName)
             .Select(c => new TeamListingModel
             {
               TeamName = c.TeamName,
               TeamBadgeUrl = c.TeamBadgeUrl,
               Nickname = c.Nickname,
               YearFounded = c.YearFounded
               

             });
            var model = new TeamIndexModel
            {
                TeamList = teams
            };
            return View(model);

        }
            public IActionResult Create()
        {

            var model = new AddTeamModel();
            var leagues = _db.Leagues.OrderBy(c => c.LeagueName)
                                        .Select(x => new { Id = x.Id, Value = x.LeagueName});
                  model.LeagueList = new SelectList(leagues, "Id", "Value");  
                    
                    return View(model);
           
            
        }
            [HttpPost]
        public async Task<IActionResult> AddTeam(AddTeamModel model, IFormCollection TeamBadgeURL)
        {
                var webRoot = _environment.WebRootPath; 
            string teamId = Convert.ToString(TeamBadgeURL["Id"]);
            string storePath = "/images/teams/";
            var path = Path.Combine(
                     Directory.GetCurrentDirectory(), "wwwroot", "images", "teams",
                     TeamBadgeURL.Files[0].FileName);
            using (var stream = new FileStream(path, FileMode.Create))
           {
               await TeamBadgeURL.Files[0].CopyToAsync(stream); 
            }
         
           
            var team = new Teams
            {
                TeamName = model.TeamName,
                Nickname = model.Nickname,
                TeamBadgeUrl = storePath + model.ImageT1.FileName,
                YearFounded = model.YearFounded,
                LeagueId = model.LeagueId
 };
            await _teamService.Create(team);
            return RedirectToAction("Index", "Teams");

        }
        public IActionResult Details(int id)
        { 
            var fans = _db.Profile.Where(p => p.TeamId == id).ToList();
            var teams = _teamService.GetById(id);
            var manager = _managerService.GetByTeamId(id);
            var stadium = _stadiumService.GetByTeamId(id);
            // var players = _playerService.GetAll()
                           // .Where(p => p.TeamId == id).ToList();
              var managerCountry = (from m in _db.Managers
                           .Where(p => p.TeamId == id)
                              join c in _db.Countries on m.CountryId equals c.Id
                              select new { c.Id, c.FlagUrl }).FirstOrDefault();
              var players = (from p in _db.Players
                            .Where(p => p.TeamId == id)
                            join c in _db.Countries on p.CountryId equals c.Id
                            select new { p.Id, p.PlayerName, p.PlayerImageUrl, p.DoB, c.FlagUrl})                
                     

           
            
            var teamdet = new TeamDetailModel();
            teamdet.Teams = teams;
            teamdet.Managers = manager;
            teamdet.ManagerCountryUrl = managerCountry.FlagUrl;
            teamdet.CountryId = managerCountry.Id;
            teamdet.Stadiums = stadium;
            teamdet.Fans = fans.Count(p => p.TeamId == teams.Id);
            teamdet.Players = players;
            //teamdet.Players = players;
            //teamdet.Position = playerPosition.Position;
            
           
            return View(teamdet);
        }
         public IActionResult LeagueTeams(int id)
           {
               
            var teams = _teamService.GetAll()
            .Where(l => l.LeagueId == id)
             .OrderBy(team => team.TeamName)
             .Select(c => new TeamListingModel
             {
                Id = c.Id,
               TeamName = c.TeamName,
               TeamBadgeUrl = c.TeamBadgeUrl,
               Nickname = c.Nickname,
               YearFounded = c.YearFounded,
               LeagueId = c.LeagueId
                
               

             });
            var model = new TeamIndexModel
            {
                TeamList = teams
            };
            return View(model);

        }



        //     var imageUri4 = "/images/users/download.jpeg";
        //     var imageUri5 = "/images/users/download.jpeg";
            
        //     if(model.ImageT1 != null)
        //     {
                
        //         var blockBlob4 = UploadTeamBadge(model.ImageT1);
        //         imageUri4 = blockBlob4.Uri.AbsoluteUri;
        //     }
        //       if(model.ImageT2 != null)
        //     {
                
        //         var blockBlob5 = UploadTeamPhoto(model.ImageT2);
        //         imageUri5 = blockBlob5.Uri.AbsoluteUri;
        //     }
        // private CloudBlockBlob UploadTeamPhoto(IFormFile file)
        // {
        //       var connectionString = _configuration.GetConnectionString("AzureStorageAccount");

        //     //get Blob Container
        //     var container = _uploadService.GetBlobContainer7(connectionString, "team-photo");

        //     // Parse the Content Disposition response header
        //     var contentDisposition = ContentDispositionHeaderValue.Parse(file.ContentDisposition);

        //     // Grab the filename
        //     var filename = contentDisposition.FileName.Trim('"');

        //     // Get a reference to a Block Blob
        //     var blockBlob = container.GetBlockBlobReference(filename);

        //     //On that block blob, Upload our file <-- file uploaded to the cloud
        //     blockBlob.UploadFromStreamAsync(file.OpenReadStream());
            
            
        //     return blockBlob;
        // }

        // private CloudBlockBlob  UploadTeamBadge(IFormFile file2)
        // {
        //     var connectionString = _configuration.GetConnectionString("AzureStorageAccount");

        //     //get Blob Container
        //     var container = _uploadService.GetBlobContainer6(connectionString, "club-badge");

        //     // Parse the Content Disposition response header
        //     var contentDisposition = ContentDispositionHeaderValue.Parse(file2.ContentDisposition);

        //     // Grab the filename
        //     var filename = contentDisposition.FileName.Trim('"');

        //     // Get a reference to a Block Blob
        //     var blockBlob = container.GetBlockBlobReference(filename);

        //     //On that block blob, Upload our file <-- file uploaded to the cloud
        //     blockBlob.UploadFromStreamAsync(file2.OpenReadStream());
            
            
        //     return blockBlob;
        // }
    }
}