using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Ballerz.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ballerz.Models.Profile
{
    public class AddProfileModel
    {
       public int Id { get; set; }


     
        public string UserId { get; set; } 


      
            public string UserName { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string ProfileImageUrl { get; set; }
            public IFormFile ImageUpload { get; set; }

            public int TeamId { get; set; }
             public SelectList TeamList { set; get; }
            
           public string TeamName { get; set; }
            
             public string ShortDescription { get; set; }
            public int CountryId { get; set; }
             public SelectList CountryList { set; get; }
            public string CountryName { get; set; }
            

            public string Location { get; set; } 
            public bool IsAdmin { get; set; }
    }
}