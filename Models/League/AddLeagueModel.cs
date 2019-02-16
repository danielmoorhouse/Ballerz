using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ballerz.Models.Leagues
{
    public class AddLeagueModel
    {
        public string LeagueName { get; set; }
        [Required]
        public string LeagueImageUrl { get; set; }
        public IFormFile LeagueImage { get; set; }
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public SelectList CountryList { set; get; }
             
    }
}