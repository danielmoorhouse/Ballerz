using System.Linq;
using System.Threading.Tasks;
using Ballerz.Data.Models;
using Ballerz.KnowledgeBase.Models;
using Ballerz.Models.PlayerHistory;
using Ballerz.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ballerz.Controllers
{
    public class PlayerHistoryController : Controller
    {
        private readonly IPlayerHistory _playerHistoryService;

        private readonly ApplicationDbContext _db;

        public PlayerHistoryController(IPlayerHistory playerHistoryService, ISeason seasonService, ApplicationDbContext db)
        {
            _playerHistoryService = playerHistoryService;
            _db = db;
        }

        public IActionResult Index(int id)
        {
            // var history = _playerHistoryService.GetAll()
            //                  .Where(h => h.Id == id)
            //                   .OrderBy(h => h.Season)
                // var playerPosition = (from player in _db.Players
                //                      .Where(p => p.TeamId == id)
                //                      .OrderBy(p => p.Position)
                //                     join Position in _db.Positions on player.PositionId equals Position.PositionId
                //                     join c in _db.Countries on player.CountryId equals c.Id
                //                     select new PlayerListingModel 
                //                     {
            var history = (from playerHistory in _db.PlayerHistories
                        .Where(h => h.PlayerId == id)
                        .OrderBy(s => s.Season)
                        join Player in _db.Players on playerHistory.PlayerId equals Player.Id
                              select new PlayerHistoryListingModel
                             {
                                PlayerId = playerHistory.PlayerId,
                                 PlayerName = Player.PlayerName,
                                 TeamName = playerHistory.TeamName,
                                 Season = playerHistory.Season,
                                 LeagueName = playerHistory.LeagueName,
                                 RedCards = playerHistory.RedCards,
                                 YellowCards = playerHistory.YellowCards,
                                 Goals = playerHistory.Goals,
                                 Position = playerHistory.Position,
                                 Points = playerHistory.Points
                             });
            var model = new PlayerHistoryIndexModel
            {
                PlayerHistoryList = history
            };
            return View(model);

        }
        public IActionResult Create()
        {
            var model = new AddPlayerHistoryModel();
            var players = _db.Players.OrderBy(p => p.TeamId)
                                         .Select(x => new { Id = x.Id, Value = x.PlayerName });
            model.PlayerList = new SelectList(players, "Id", "Value");
            var leagues = _db.Leagues.OrderBy(c => c.LeagueName)
                                       .Select(x => new { Id = x.Id, Value = x.LeagueName });
            model.LeagueList = new SelectList(leagues, "Value", "Value");
            var season = _db.Seasons.OrderBy(s => s.Season)
                                         .Select(x => new { Id = x.Id, Value = x.Season });
            model.SeasonList = new SelectList(season, "Value", "Value");
            var team = _db.Teams.OrderBy(s => s.TeamName)
                           .Select(x => new { Id = x.Id, Value = x.TeamName });
            model.TeamList = new SelectList(team, "Value", "Value");

            return View(model);
        }
        public async Task<IActionResult> AddPlayerHistory(AddPlayerHistoryModel model)
        {
            var history = new PlayerHistory
            {

                PlayerId = model.PlayerId,
                TeamName = model.TeamName,
                Season = model.Season,
                LeagueName = model.LeagueName,
                RedCards = model.RedCards,
                YellowCards = model.YellowCards,
                Goals = model.Goals,
                Position = model.Position,
                Points = model.Points


            };
            await _playerHistoryService.Create(history);
            return RedirectToAction("Index", "Home");
        }
        // public IActionResult PlayerHistory(int id)
        // {
        //    var history = _playerHistoryService.GetAll()
        //                     .Where(h => h.PlayerId == id)
        //                     .OrderBy(h => h.Season)
        //                     .Select(c => new PlayerHistoryListingModel
        //                     {

        //                         TeamName  = c.TeamName,
        //                         PlayerId = c.PlayerId,
        //                         PlayerName = c.PlayerName,
        //                         Season = c.Season,
        //                         LeagueName = c.LeagueName,
        //                         RedCards = c.RedCards,
        //                         YellowCards = c.YellowCards,
        //                         Goals = c.Goals,
        //                         Position = c.Position,
        //                         Points = c.Points
        //                     });
        //                       var model = new PlayerHistoryIndexModel
        //         {
        //             PlayerHistoryList = history
        //         };
        //         return View(model);

        // }
    }
}