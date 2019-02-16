using System.Collections.Generic;

namespace Ballerz.KnowledgeBase.Models
{
    public class Leagues
    {
        public int Id { get; set; }
        public string LeagueName { get; set; }
        public string LeagueImageUrl { get; set; }
        
        public int CountryId { get; set; }
       
        public Countries Countries { get; set; }
    }
}