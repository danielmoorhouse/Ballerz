
using System;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Ballerz.Data;
using Ballerz.Data.Models;
using Ballerz.KnowledgeBase.Models;
using Ballerz.Models.Manager;
using Ballerz.Models.Managers;
using Ballerz.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Microsoft.WindowsAzure.Storage.Blob;
using static System.Net.Mime.MediaTypeNames;

namespace Ballerz.Web.Controllers
{
    public class ManagersController : Controller
    {
         private readonly IManager _managerService;
         private readonly ICountries _countriesService;
        private readonly IUpload _uploadService;
        private readonly IConfiguration _configuration;
        private readonly IHostingEnvironment _environment;
        private readonly ApplicationDbContext _db;


        public ManagersController(IManager managerService, IConfiguration configuration, IUpload uploadService, 
            ICountries countriesService, IHostingEnvironment environment, ApplicationDbContext db)
        {
            _managerService = managerService;
            _countriesService = countriesService;
            _configuration = configuration;
            _uploadService = uploadService;
            _environment = environment;
            _db = db;
        }
            public IActionResult Index()
        {
                  var managers = (from m in _db.Managers
                                     .OrderBy(p => p.ManagerName)
                                    join t in _db.Teams on m.TeamId equals t.Id
                                    join c in _db.Countries on m.CountryId equals c.Id
                                    select new ManagersListingModel 
                                    {
                                        Id = m.Id,
                                        Name = m.ManagerName,
                                        DoB = m.DoB,
                                        ManagerImageUrl = m.ManagerImageUrl,
                                        TeamName = t.TeamName,
                                        CountryFlagUrl = c.FlagUrl
            
                
              });
            
            var model = new ManagersIndexModel
            {
                ManagersList = managers
            };
            return View(model);

        }
         public IActionResult Create()
        {
             var model = new AddManagerModel();
            var teams = _db.Teams.OrderBy(c => c.TeamName)
                                        .Select(x => new { Id = x.Id, Value = x.TeamName});
                  model.TeamList = new SelectList(teams, "Id", "Value"); 

             var countries = _db.Countries.OrderBy(c => c.Name)
                                        .Select(x => new { Id = x.Id, Value = x.Name});
            
            model.CountryList = new SelectList(countries, "Id", "Value");
      
        return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AddManager(AddManagerModel model, IFormCollection image1)
        {
               // var webRoot = _environment.WebRootPath; 
            //string managerId = Convert.ToString(image1["Id"]);
            string storePath = "/images/managers/";
            var path = Path.Combine(
                     Directory.GetCurrentDirectory(), "wwwroot", "images", "managers",
                     image1.Files[0].FileName);
                  
            using (var stream = new FileStream(path, FileMode.Create))
           {
               await image1.Files[0].CopyToAsync(stream); 
               
            }
              var manager = new Managers
            {
                ManagerName = model.Name,
                DoB = model.DoB,
                CountryId = model.CountryId,
                TeamId = model.TeamId,
                ManagerImageUrl = storePath + model.ImageUpload.FileName,
                BirthPlace = model.BirthPlace
            
            };
            await _managerService.Create(manager);
            return RedirectToAction("Index", "Managers");

        }
             public IActionResult CountryManagers(int id)
        {
            var managers = (from m in _db.Managers
           
            .Where(l => l.CountryId == id)
    
                 .OrderBy(p => p.ManagerName)
                                    join t in _db.Teams on m.TeamId equals t.Id
                                    join c in _db.Countries on m.CountryId equals c.Id
                                    select new ManagersListingModel 
                                    {
                                        Id = m.Id,
                                        Name = m.ManagerName,
                                        DoB = m.DoB,
                                        ManagerImageUrl = m.ManagerImageUrl,
                                        CountryFlagUrl = c.FlagUrl,
                                        TeamId = t.Id,
                                        TeamName = t.TeamName,
                                        TeamBadge = t.TeamBadgeUrl
                                    });
            var model = new ManagersIndexModel
            {
                ManagersList = managers
            };
            return View(model);

        }

           public IActionResult Details(int id)
        {
            var managerTeam = (from m in _db.Managers
                           .Where(p => p.Id == id)
                              join t in _db.Teams on m.TeamId equals t.Id
                              join c in _db.Countries on m.CountryId equals c.Id
                              select new 
                              {
                                   m.Id,
                                    m.ManagerName,
                                     m.DoB, 
                                     m.BirthPlace,
                                      m.ManagerImageUrl,
                                       t.TeamName, 
                                       t.TeamBadgeUrl,
                                       c.Name, 
                                       c.FlagUrl 
                                       
                                       
                                       }).FirstOrDefault();
                              
        

            var mdm = new ManagerDetailModel();
            mdm.ManagerName = managerTeam.ManagerName;
            mdm.DoB = managerTeam.DoB;
            mdm.PlaceOfBirth = managerTeam.BirthPlace;
            mdm.ManagerImageUrl = managerTeam.ManagerImageUrl;
            mdm.TeamName = managerTeam.TeamName;
            mdm.TeamBadgeUrl = managerTeam.TeamBadgeUrl;
            mdm.CountryName = managerTeam.Name;
            mdm.FlagUrl = managerTeam.FlagUrl;
              
            



            return View(mdm);
        }
           // var imageUri = "/images/users/default.png";
            // var imageUri2 = "/images/users/default.png";
            
            // if(model.ImageUpload != null)
            // {
                
            //     var blockBlob = UploadImage(model.ImageUpload);
            //     imageUri = blockBlob.Uri.AbsoluteUri;
            // }
            //     if(model.ImageUpload2 != null)
            // {
            //     var blockBlob2 = UploadFlag(model.ImageUpload2);
            //     imageUri2 = blockBlob2.Uri.AbsoluteUri;
            // }

        //       private CloudBlockBlob UploadImage(IFormFile file1)
        // {
        //         //Connect to an Azure Storage Account Container
        //     var connectionString = _configuration.GetConnectionString("AzureStorageAccount");

        //     //get Blob Container
        //     var container = _uploadService.GetBlobContainer2(connectionString, "manager-images");

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
        //         private CloudBlockBlob UploadFlag(IFormFile file2)
        // {
        //         //Connect to an Azure Storage Account Container
        //     var connectionString = _configuration.GetConnectionString("AzureStorageAccount");

        //     //get Blob Container
        //     var container = _uploadService.GetBlobContainer(connectionString, "country-flag");

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