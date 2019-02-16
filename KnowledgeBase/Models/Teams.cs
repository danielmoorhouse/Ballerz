using System;

namespace Ballerz.KnowledgeBase.Models
{
    public class Teams
    {
        public int Id { get; set; }
        public string TeamName { get; set; }
        public string Nickname { get; set; }
        public string TeamBadgeUrl { get; set; }
        
        public string YearFounded { get; set; }
        public int LeagueId { get; set; }
        public string LeagueName { get; set; }
        public Leagues Leagues { get; set; }
        
    }
}