using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ballerz.Models.PlayerHistory
{
    public class AddPlayerHistoryModel
    {
        public int PlayerId { get; set; }
        public SelectList PlayerList { get; set; }
       
        public string TeamName { get; set; }
        public SelectList TeamList { get; set; }
        public string Season { get; set; }
        public SelectList SeasonList { get; set; }
        public string LeagueName { get; set; }
        public SelectList LeagueList { get; set; }

        public string RedCards { get; set; }
        public string YellowCards { get; set; }
        public string Goals { get; set; }
        public string Position { get; set; }
        public string Points { get; set; }
    }
}