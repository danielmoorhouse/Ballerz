using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ballerz.Models.Stadiums
{
    public class AddStadiumModel
    {
        public int CountryId { get; set; }
        public SelectList CountryList { set; get; }
        public int TeamId { get; set; }
        public SelectList TeamList { get; set; }
        public string StadiumName { get; set; }
        
        public string Capacity { get; set; }

        public string BuiltIn { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string PostCode { get; set; }
        public string ImageUrl1 { get; set; }
        public IFormFile ImageS1 { get; set; }
        
    }
}