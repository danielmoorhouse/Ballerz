using System.Linq;
using System.Threading.Tasks;
using Ballerz.Data;
using Ballerz.Data.Models;
using Ballerz.KnowledgeBase.Models;
using Ballerz.Models.ClubHistory;
using Ballerz.Models.Teams;
using Ballerz.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ballerz.Controllers
{
    public class ClubHistoryController : Controller
    {
           private readonly IClubHistory _historyService;
           private readonly ISeason _seasonService;
           private readonly ApplicationDbContext _db;
           private readonly ITeam _teamService;

        public ClubHistoryController(IClubHistory historyService, ISeason seasonService, ApplicationDbContext db, ITeam teamService)
        {
            _historyService = historyService;
          _seasonService = seasonService;
          _db = db;
          _teamService = teamService;
        }
           public IActionResult Create()
        {
        var model = new AddClubHistoryModel();
             var leagues = _db.Leagues.OrderBy(c => c.LeagueName)
                                        .Select(x => new { Id = x.Id, Value = x.LeagueName});
                  model.LeagueList = new SelectList(leagues, "Value", "Value");  
             var season = _db.Seasons.OrderBy(s => s.Season) 
                                        .Select(x => new { Id = x.Id, Value = x.Season});
                  model.SeasonList = new SelectList(season, "Value", "Value");   
                         var team = _db.Teams.OrderBy(s => s.TeamName) 
                                        .Select(x => new { Id = x.Id, Value = x.TeamName});
                  model.TeamList = new SelectList(team, "Id", "Value");                       
        return View(model);
        }

         public async Task<IActionResult> AddClubHistory(AddClubHistoryModel model)
    {
              var history = new ClubHistory
            {
                TeamId = model.TeamId,
                Season = model.Season,
                LeagueName = model.LeagueName,
                Position = model.Position,
                Points = model.Points
                 
                
            };
            await _historyService.Create(history);
            return RedirectToAction("Index", "Home");
    }
    public IActionResult TeamHistory(int id)
    {
        // var teamName = _teamService.GetAll()
        //                 .Where(c => c.Id == id)
        //                 .Select(t => new TeamDetailModel
        //                 {
        //                     Teams = t.TeamName
        //                 });
        ViewBag.TeamName = _teamService.GetAll()
                            .Where(c => c.Id == id).FirstOrDefault().TeamName;
       var history = _historyService.GetAll()
                        .Where(h => h.TeamId == id)
                        .OrderBy(h => h.Season)
                        .Select(c => new ClubHistoryListingModel
                        {
                            Season = c.Season,
                            LeagueName = c.LeagueName,
                            Position = c.Position,
                            Points = c.Points
                        });
                          var model = new ClubHistoryIndexModel
            {
                HistoryList = history,
                
            };
            return View(model);
            
    }
    }
}