using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ballerz.Models.Player
{
    public class AddPlayerModel
    {
          public int CountryId { get; set; }
        
        public SelectList CountryList { set; get; }
          public int TeamId { get; set; }
         public SelectList TeamList { set; get; }

         public int PositionId { get; set; }
         public SelectList PositionList { get; set; }

        public string PlayerName { get; set; }
        public string Birthplace { get; set; }

        
        public DateTime DoB { get; set; }
         public string PlayerImageUrl { get; set; }
        public IFormFile ImageUpload { get; set; }
        
        
    }
}