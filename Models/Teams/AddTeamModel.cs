using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ballerz.Models.Teams
{
    public class AddTeamModel
    {
        public string TeamName { get; set; }
        public string TeamBadgeUrl { get; set; }
        public IFormFile ImageT1 { get; set; }
    
        public string Nickname { get; set; }
        public string YearFounded { get; set; }

        public int LeagueId { get; set; }
       
        public SelectList LeagueList { set; get; }

          }
}