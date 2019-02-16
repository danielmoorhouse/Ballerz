using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Ballerz.Data;
using Ballerz.Data.Models;
using Ballerz.KnowledgeBase.Models;
using Ballerz.Models.Stadiums;
using Ballerz.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Microsoft.WindowsAzure.Storage.Blob;

namespace Ballerz.Web.Controllers
{
    public class StadiumsController : Controller
    {
         private readonly ApplicationDbContext _db;
          private readonly ICountries _countriesService;
        private readonly IUpload _uploadService;
        private readonly IConfiguration _configuration;
        private readonly IStadium _stadiumService;
        private readonly IHostingEnvironment _environment;

         public StadiumsController(IManager managerService, IConfiguration configuration, IUpload uploadService, ICountries countriesService,
                IStadium stadiumService, IHostingEnvironment environment, ApplicationDbContext db)
        {
            _countriesService = countriesService;
            _configuration = configuration;
            _uploadService = uploadService;
            _stadiumService = stadiumService;
            _db = db;
            _environment = environment;
        }

              public IActionResult Index()
        {
                 var stadiums  = (from s in _db.Stadiums
                                     .OrderBy(p => p.StadiumName)
                                    join t in _db.Teams on s.TeamId equals t.Id
                                    join c in _db.Countries on s.CountryId equals c.Id
                                    select new StadiumListingModel 
                                    {
                                        StadiumName = s.StadiumName,
                                        CountryName = s.CountryId,
                                        Capacity = s.Capacity,
                                        CountryFlagUrl = c.FlagUrl,
                                        ImageUrl1 = s.ImageUrl1,
                                        TeamName = t.TeamName
            // var stadiums = _stadiumService.GetAll()
            //  .OrderBy(stadium => stadium.StadiumName)
            //  .Select(c => new StadiumListingModel
            //  {
            //    StadiumName = c.StadiumName,
            //    CountryName = c.CountryId,
            //    Capacity = c.Capacity,
            //    BuiltIn = c.BuiltIn,
            //    Address2 = c.Address2,
            //    ImageUrl1 = c.ImageUrl1
               

             });
            var model = new StadiumIndexModel
            {
                StadiumList = stadiums
            };
            return View(model);

        }

        public IActionResult Create()
        {
          var model = new AddStadiumModel();
           var countries = _db.Countries.OrderBy(c => c.Name)
                                        .Select(x => new { Id = x.Id, Value = x.Name});
            
            model.CountryList = new SelectList(countries, "Id", "Value");
            
             var teams = _db.Teams.OrderBy(c => c.TeamName)
                                        .Select(x => new { Id = x.Id, Value = x.TeamName});
            
            model.TeamList = new SelectList(teams, "Id", "Value");
         
          

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AddStadium(AddStadiumModel model, IFormCollection StadiumImage)
        {
             string storePath = "/images/stadiums/";
            var path = Path.Combine(
                     Directory.GetCurrentDirectory(), "wwwroot", "images", "stadiums",
                     StadiumImage.Files[0].FileName);
                  
            using (var stream = new FileStream(path, FileMode.Create))
           {
               await StadiumImage.Files[0].CopyToAsync(stream); 
               
            }
         
            var stadium = new Stadiums
            {
                StadiumName = model.StadiumName,
                BuiltIn = model.BuiltIn,
                CountryId = model.CountryId,
                Capacity = model.Capacity,
                Address1 = model.Address1,
                Address2 = model.Address2,
                PostCode = model.PostCode,
                ImageUrl1 = storePath + model.ImageS1.FileName,
                TeamId = model.TeamId
                
            };
            await _stadiumService.Create(stadium);
            return RedirectToAction("Index", "Stadiums");

        }
        //    var imageUri = "/images/users/default.png";
        //     var imageUri2 = "/images/users/default.png";
            
        //     if(model.ImageS1 != null)
        //     {
                
        //         var blockBlob = UploadImage1(model.ImageS1);
        //         imageUri = blockBlob.Uri.AbsoluteUri;
        //     }
        //         if(model.ImageS2 != null)
        //     {
        //         var blockBlob2 = UploadImage2(model.ImageS2);
        //         imageUri2 = blockBlob2.Uri.AbsoluteUri;
        //     }
        // private CloudBlockBlob UploadImage1(IFormFile file1)
        // {
        //         //Connect to an Azure Storage Account Container
        //     var connectionString = _configuration.GetConnectionString("AzureStorageAccount");

        //     //get Blob Container
        //     var container = _uploadService.GetBlobContainer4(connectionString, "stadium-images");

        //     // Parse the Content Disposition response header
        //     var contentDisposition = ContentDispositionHeaderValue.Parse(file1.ContentDisposition);

        //     // Grab the filename
        //     var filename = contentDisposition.FileName.Trim('"');

        //     // Get a reference to a Block Blob
        //     var blockBlob1 = container.GetBlockBlobReference(filename);

        //     //On that block blob, Upload our file <-- file uploaded to the cloud
        //     blockBlob1.UploadFromStreamAsync(file1.OpenReadStream());
            
            
        //     return blockBlob1;
        
        // }
        //         private CloudBlockBlob UploadImage2(IFormFile file2)
        // {
        //         //Connect to an Azure Storage Account Container
        //     var connectionString = _configuration.GetConnectionString("AzureStorageAccount");

        //     //get Blob Container
        //     var container = _uploadService.GetBlobContainer(connectionString, "manager-images");

        //     // Parse the Content Disposition response header
        //     var contentDisposition = ContentDispositionHeaderValue.Parse(file2.ContentDisposition);

        //     // Grab the filename
        //     var filename = contentDisposition.FileName.Trim('"');

        //     // Get a reference to a Block Blob
        //     var blockBlob2 = container.GetBlockBlobReference(filename);

        //     //On that block blob, Upload our file <-- file uploaded to the cloud
        //     blockBlob2.UploadFromStreamAsync(file2.OpenReadStream());
            
            
        //     return blockBlob2;
        
        // }
    }
}