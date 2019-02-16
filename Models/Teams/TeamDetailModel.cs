using System.Collections.Generic;
using Ballerz.KnowledgeBase.Models;

namespace Ballerz.Models.Teams
{
    public class TeamDetailModel
    {
        public Ballerz.KnowledgeBase.Models.Teams Teams { get; set; }
        public Ballerz.KnowledgeBase.Models.Leagues Leagues { get; set; }
        public Ballerz.KnowledgeBase.Models.Managers Managers { get; set; }

         public Ballerz.KnowledgeBase.Models.Players Players { get; set;}
         public string PlayerName { get; set; }
         public string PlayerImageUrl { get; set; }
        // public string 

        public int Fans { get; set; }
        public string LeagueImageUrl { get; set; }
        public int CountryId { get; set; }
        public string ManagerCountryUrl { get; set; }
        public Ballerz.KnowledgeBase.Models.Stadiums Stadiums { get; set; }
         public string  Position { get; set; }
        
    }
}