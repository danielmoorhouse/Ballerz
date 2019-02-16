using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ballerz.Models.Stadiums
{
    public class StadiumListingModel
    {
        public int Id { get; set; }
        public int CountryName { get; set; }
        public string CountryFlagUrl { get; set; }
        [ForeignKey("CountryName")]
        public virtual Ballerz.KnowledgeBase.Models.Countries Countries { get; set;}
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public virtual Ballerz.KnowledgeBase.Models.Teams Teams { get; set; }

        public string StadiumName { get; set; }
        
        public string Capacity { get; set; }
        public string Address2 { get; set; }

        public string BuiltIn { get; set; }
        public string ImageUrl1 { get; set; }
    }
}