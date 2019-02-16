using System.Linq;
using System.Threading.Tasks;
using Ballerz.KnowledgeBase.Models;
using Ballerz.Models.Positions;
using Ballerz.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ballerz.Controllers
{
    public class PositionsController : Controller
    {
          private readonly IPosition _positionService;

        public PositionsController(IPosition positionService)
        {
          _positionService = positionService;
        }
           public IActionResult Create()
        {
        var model = new AddPositionModel();
        return View(model);
        }
    

    public async Task<IActionResult> AddPosition(AddPositionModel model)
    {
              var position = new Positions
            {
                Position = model.Position
                
            };
            await _positionService.Create(position);
            return RedirectToAction("Index", "Positions");
    }
    public IActionResult Index()
    {
        var position = _positionService.GetAll()
         .OrderBy(positions => positions.Position)
             .Select(c => new PositionListingModel
             
        {
           Position = c.Position
        });
         var model = new PositionIndexModel
            {
                PositionList = position
            };
            return View(model);
    }
        
    }
}