using System;
using System.ComponentModel.DataAnnotations;

namespace Ballerz.KnowledgeBase.Models
{
    public class Stadiums
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public Countries Countries { get; set; }
        public int TeamId { get; set; }
        public Teams Teams { get; set; }
        public string StadiumName { get; set; }
        
        public string Capacity { get; set; }

        public string BuiltIn { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string PostCode { get; set; }
        public string ImageUrl1 { get; set; }
        public string ImageUrl2 { get; set; }
               

        
    }
}