using System.Linq;
using System.Threading.Tasks;
using Ballerz.KnowledgeBase.Models;
using Ballerz.Models.Season;
using Ballerz.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ballerz.Controllers
{
    public class SeasonsController : Controller
    {
        private readonly ISeason _seasonService;

        public SeasonsController(ISeason seasonService)
        {
          _seasonService = seasonService;
        }
           public IActionResult Create()
        {
        var model = new AddSeasonModel();
        return View(model);
        }
    

    public async Task<IActionResult> AddSeason(AddSeasonModel model)
    {
              var season = new Seasons
            {
                Season = model.Season
                
            };
            await _seasonService.Create(season);
            return RedirectToAction("Index", "Home");
    }
    public IActionResult Index()
    {
        var season = _seasonService.GetAll()
         .OrderBy(seasons => seasons.Season)
             .Select(c => new SeasonListingModel
             
        {
           Season = c.Season
        });
         var model = new SeasonIndexModel
            {
                SeasonList = season
            };
            return View(model);
    }
    }
}