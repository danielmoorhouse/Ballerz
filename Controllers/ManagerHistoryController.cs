using System.Linq;
using System.Threading.Tasks;
using Ballerz.Data.Models;
using Ballerz.KnowledgeBase.Models;
using Ballerz.Models.ManagerHistory;
using Ballerz.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ballerz.Controllers
{
    public class ManagerHistoryController : Controller
    {
       
        private readonly IManagerHistory _managerHistoryService;
        private readonly IManager _managerService;

        private readonly ApplicationDbContext _db;

        public ManagerHistoryController(IManagerHistory managerHistoryService, ISeason seasonService, ApplicationDbContext db, IManager managerService)
        {
            _managerHistoryService = managerHistoryService;
            _db = db;
            _managerService = managerService;
        }

        public IActionResult Index(int id)
        {
            ViewBag.ManagerName = _managerService.GetAll()
                                .Where(p => p.Id == id).FirstOrDefault().ManagerName;
                var history = (from managerHistory in _db.ManagerHistories
                        .Where(h => h.ManagerId == id)
                        .OrderBy(s => s.Season)
                        join Team in _db.Teams on managerHistory.TeamId equals Team.Id
                              select new ManagerHistoryListingModel
                            {
                               TeamName = Team.TeamName,
                               Season = managerHistory.Season,
                               LeagueName = managerHistory.LeagueName,
                               Position = managerHistory.Position,
                               Points = managerHistory.Points

                            });                    
        
                             
            var model = new ManagerHistoryIndexModel
            {
                ManagerHistoryList = history
            };
            return View(model);

        }
        public IActionResult Create()
        {
            var model = new AddManagerHistoryModel();
            var managers = _db.Managers.OrderBy(p => p.Id)
                                         .Select(x => new { Id = x.Id, Value = x.ManagerName });
            model.ManagerList = new SelectList(managers, "Id", "Value");
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
        public async Task<IActionResult> AddManagerHistory(AddManagerHistoryModel model)
        {
            var history = new ManagerHistory
            {

                ManagerId = model.ManagerId,
                TeamName = model.TeamName,
                Season = model.Season,
                Position = model.Position,
                Points = model.Points


            };
            await _managerHistoryService.Create(history);
            return RedirectToAction("Index", "Home");
        } 
    }
}