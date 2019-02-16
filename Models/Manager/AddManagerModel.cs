using Microsoft.AspNetCore.Http;
using Ballerz.KnowledgeBase.Models;
using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ballerz.Models.Managers
{
    public class AddManagerModel
    {
        public string Name { get; set; }
        public DateTime DoB { get; set; }
        public string ManagerImageUrl { get; set; }
        public IFormFile ImageUpload { get; set; }
        
        public string BirthPlace { get; set; }
        public int CountryId { get; set; }
        
        public SelectList CountryList { set; get; }
          public int TeamId { get; set; }
        
        public SelectList TeamList { set; get; }
        
    }
}