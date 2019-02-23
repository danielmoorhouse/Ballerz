using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Ballerz.Data;
using Ballerz.Data.Models;
using Ballerz.KnowledgeBase.Models;
using Ballerz.Models.Player;
using Ballerz.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Configuration;

namespace Ballerz.Controllers
{
    public class PlayersController : Controller
    {
        private readonly IPlayer _playerService;
        private readonly ICountries _countriesService;
        private readonly IUpload _uploadService;
        private readonly IConfiguration _configuration;
        private readonly IHostingEnvironment _environment;
        private readonly ApplicationDbContext _db;
        private readonly ITeam _teamService;
        private readonly IPosition _positionService;


        public PlayersController(IPlayer playerService, IConfiguration configuration, IUpload uploadService,
            ICountries countriesService, IHostingEnvironment environment, ApplicationDbContext db, ITeam teamService, IPosition positionService)
        {
            _playerService = playerService;
            _countriesService = countriesService;
            _configuration = configuration;
            _uploadService = uploadService;
            _environment = environment;
            _db = db;
            _teamService = teamService;
            _positionService = positionService;
        }

        public IActionResult List()
        {

            var players = _playerService.GetAll()
             .OrderBy(player => player.PlayerName)
             .Select(c => new PlayerListingModel
             {
                 Id = c.Id,
                 PlayerName = c.PlayerName,
                 DoB = c.DoB,
                 PlayerImageUrl = c.PlayerImageUrl,
                 Birthplace = c.Birthplace,
             });

            var model = new PlayerIndexModel
            {
                PlayerList = players
            };
            return View(model);

        }
           public IActionResult PlayerTeam(int id)
        {

            var teamName = _db.Teams.Where(t => t.Id == id).FirstOrDefault().TeamName;
             var playerPosition = (from player in _db.Players
                                     .Where(p => p.TeamId == id)
                                     .OrderBy(p => p.Position)
                                    join Position in _db.Positions on player.PositionId equals Position.PositionId
                                    join c in _db.Countries on player.CountryId equals c.Id
                                    select new PlayerListingModel 
                                    {
                                         Id = player.Id,
                                         TeamId = player.TeamId,
                                         TeamName = teamName,
                                         PlayerName = player.PlayerName,
                                         DoB = player.DoB,
                                         PlayerImageUrl = player.PlayerImageUrl,
                                         PositionId = Position.PositionId,
                                         Position = Position.Position,
                                         FlagUrl = c.FlagUrl

                                         
                                         
                                     }).ToList();
    

            var model = new PlayerIndexModel
            {
                PlayerList = playerPosition
            };
            return View(model);

        }

        public IActionResult Create()
        {
            var model = new AddPlayerModel();
            var teams = _db.Teams.OrderBy(c => c.TeamName)
                                        .Select(x => new { Id = x.Id, Value = x.TeamName });
            model.TeamList = new SelectList(teams, "Id", "Value");

            var countries = _db.Countries.OrderBy(c => c.Name)
                                       .Select(x => new { Id = x.Id, Value = x.Name });

            model.CountryList = new SelectList(countries, "Id", "Value");

            var positions = _db.Positions.OrderBy(c => c.Position)
                                      .Select(x => new { Id = x.PositionId, Value = x.Position });

            model.PositionList = new SelectList(positions, "Id", "Value");

            return View(model);

        }
        [HttpPost]
        public async Task<IActionResult> AddPlayer(AddPlayerModel model, IFormCollection image1)
        {
            // var webRoot = _environment.WebRootPath; 
            //string managerId = Convert.ToString(image1["Id"]);
            string storePath = "/images/players/";
            var path = Path.Combine(
                     Directory.GetCurrentDirectory(), "wwwroot", "images", "players",
                     image1.Files[0].FileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await image1.Files[0].CopyToAsync(stream);

            }
            var player = new Players
            {
                PlayerName = model.PlayerName,
                Birthplace = model.Birthplace,
                DoB = model.DoB,
                CountryId = model.CountryId,
                TeamId = model.TeamId,
                PositionId = model.PositionId,
                PlayerImageUrl = storePath + model.ImageUpload.FileName,


            };
            await _playerService.Create(player);
            return RedirectToAction("Index", "Players");

        }
        public IActionResult Details(int id)
        {
            var playerTeam = (from Player in _db.Players
                           .Where(p => p.Id == id)
                              join Team in _db.Teams on Player.TeamId equals Team.Id
                              select new { Player.Id, Player.PlayerName, Player.PlayerImageUrl, Player.Birthplace, Player.DoB,
                                            Team.TeamName, Team.TeamBadgeUrl })
                              .FirstOrDefault();
            var playerCountry = (from player in _db.Players
                           .Where(p => p.Id == id)
                                 join Country in _db.Countries on player.CountryId equals Country.Id
                                 select new { Country.FlagUrl }).FirstOrDefault();
            var playerPosition = (from player in _db.Players
                           .Where(p => p.Id == id)
                                  join Position in _db.Positions on player.PositionId equals Position.PositionId
                                  select new { Position.Position }).FirstOrDefault();

            var playerdet = new PlayerDetailModel();
            playerdet.Id = playerTeam.Id;
            playerdet.PlayerName = playerTeam.PlayerName;
            playerdet.PlayerImageUrl = playerTeam.PlayerImageUrl;
            playerdet.DoB = playerTeam.DoB;
            playerdet.BirthPlace = playerTeam.Birthplace;
            playerdet.TeamName = playerTeam.TeamName;
            playerdet.TeamBadgeUrl = playerTeam.TeamBadgeUrl;
            playerdet.FlagUrl = playerCountry.FlagUrl;
            playerdet.Position = playerPosition.Position;



            return View(playerdet);
        }
        public IActionResult Delete()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            Players player = _db.Players.Find(id);
            _db.Remove(player);
           await _db.SaveChangesAsync();
            return RedirectToAction("List","Players");
        }
    }
}