using System;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Ballerz.KnowledgeBase.Models;
using Ballerz.Models;
using Ballerz.Models.Countries;
using Ballerz.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.FileProviders;

using Microsoft.WindowsAzure.Storage.Blob;

namespace Ballerz.Web.Controllers
{
    public class CountriesController : Controller
    {
        private readonly ICountries _countriesService;
        private readonly IFileProvider _fileProvider;
        private readonly IConfiguration _configuration;
        private readonly IHostingEnvironment _environment;


        public CountriesController(ICountries countriesService, IConfiguration configuration,
            IFileProvider fileProvider, IHostingEnvironment environment)
        {
            _countriesService = countriesService;
            _configuration = configuration;
            _fileProvider = fileProvider;
           
            _environment = environment;
        }
        public IActionResult Index()
        {
           
            var countries = _countriesService.GetAll()
             .OrderBy(country => country.Name)
             .Select(c => new CountriesListingModel
             {
                Id= c.Id,
                Name = c.Name,
                FlagUrl = c.FlagUrl
             });
            var model = new CountriesIndexModel
            {
                CountriesList = countries
            };
            return View(model);

        }
        public IActionResult Create()
        {
        var model = new AddCountryModel();
        return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AddCountry(AddCountryModel model, IFormCollection UploadFlag)
        {
           var webRoot = _environment.WebRootPath; 
            string countryId = Convert.ToString(UploadFlag["Id"]);
            string storePath = "/images/flags/";
            var path = Path.Combine(
                     Directory.GetCurrentDirectory(), "wwwroot", "images", "flags",
                     UploadFlag.Files[0].FileName);
            using (var stream = new FileStream(path, FileMode.Create))
           {
               await UploadFlag.Files[0].CopyToAsync(stream); 
            }

      
         
       
            var countries = new Countries
            {
                Name = model.Name,
                FlagUrl = storePath + model.UploadFlag.FileName
            };
            await _countriesService.Create(countries);
            return RedirectToAction("Index", "Countries");

        }

      
    }    
   }
   
  // string storePath = "wwwroot/images/flags/";
        //  var filename = ContentDispositionHeaderValue.Parse(UploadFlag.ContentDisposition).FileName.Trim('"');
        // var path = Path.Combine(Directory.GetCurrentDirectory(), storePath, UploadFlag.FileName);
        // using (System.IO.Stream stream = new FileStream(path, FileMode.Create))
        //  {
        //     await UploadFlag.CopyToAsync(stream);
        //  } 


        // var imageUri = "/images/users/default.png";
            
            // if(model.ImageUpload != null)
            // {
            //     var blockBlob = UploadFlag(model.ImageUpload);
            //     imageUri = blockBlob.Uri.AbsoluteUri;
            // }
        //  private CloudBlockBlob UploadFlag(IFormFile file)
        // {
        //         //Connect to an Azure Storage Account Container
        //     var connectionString = _configuration.GetConnectionString("AzureStorageAccount");

        //     //get Blob Container
        //     var container = _uploadService.GetBlobContainer(connectionString, "country-flags");

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
