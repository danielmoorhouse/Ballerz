using System;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Ballerz.Data;
using Ballerz.Data.Models;
using Ballerz.KnowledgeBase.Models;
using Ballerz.Models.Leagues;
using Ballerz.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Microsoft.WindowsAzure.Storage.Blob;

namespace Ballerz.Web.Controllers
{
    public class LeaguesController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly ILeague _leagueService;
         private readonly IUpload _uploadService;
        private readonly IConfiguration _configuration;
        private readonly IHostingEnvironment _environment;

        public LeaguesController(ApplicationDbContext db, IConfiguration configuration, IUpload uploadService, 
            ILeague leagueService, IHostingEnvironment environment)
        {
           _db = db;
           _leagueService = leagueService;
           _uploadService = uploadService;
           _configuration = configuration;
           _environment = environment;
        }

         public IActionResult Index()
        {
            var leagues = _leagueService.GetAll()
             .OrderByDescending(league => league.LeagueName)
             .Select(c => new LeagueListingModel
             {
                LeagueName = c.LeagueName,
                LeagueImageUrl = c.LeagueImageUrl,
                CountryId = c.CountryId
               

             });
            var model = new LeagueIndexModel
            {
                LeagueList = leagues
            };
            return View(model);

        }
         public IActionResult CountryLeagues(int id)
        {
            var leagues = _leagueService.GetAll()
            .Where(l => l.CountryId == id)
            // .OrderBy(league => league.LeagueName)
             .Select(c => new LeagueListingModel
             {
                 Id = c.Id,
                LeagueName = c.LeagueName,
                LeagueImageUrl = c.LeagueImageUrl,
                CountryId = c.CountryId
                
               

             });
            var model = new LeagueIndexModel
            {
                LeagueList = leagues
            };
            return View(model);

        }
          public IActionResult Create()
        {
           var countries = _db.Countries.OrderBy(c => c.Name)
                                        .Select(x => new { Id = x.Id, Value = x.Name});
            var country = new AddLeagueModel();
            country.CountryList = new SelectList(countries, "Id", "Value");
         
          

            return View(country);
        }
         [HttpPost]
        public async Task<IActionResult> AddLeague(AddLeagueModel model, IFormCollection LeagueImage)
        {
              var webRoot = _environment.WebRootPath; 
            string leagueId = Convert.ToString(LeagueImage["Id"]);
            string storePath = "/images/leagues/";
            var path = Path.Combine(
                     Directory.GetCurrentDirectory(), "wwwroot", "images", "leagues",
                     LeagueImage.Files[0].FileName);
            using (var stream = new FileStream(path, FileMode.Create))
           {
               await LeagueImage.Files[0].CopyToAsync(stream); 
            }
           
            var league = new Leagues
            {
               LeagueName = model.LeagueName,
               CountryId = model.CountryId,
               LeagueImageUrl = storePath + model.LeagueImage.FileName
               
            };
            await _leagueService.Create(league);
            return RedirectToAction("Index", "Leagues");

        }

        // private CloudBlockBlob UploadLeagueImage(IFormFile file)
        // {
        //         //Connect to an Azure Storage Account Container
        //     var connectionString = _configuration.GetConnectionString("AzureStorageAccount");

        //     //get Blob Container
        //     var container = _uploadService.GetBlobContainer5(connectionString, "league-images");

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
    }
}