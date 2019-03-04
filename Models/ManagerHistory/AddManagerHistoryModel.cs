using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ballerz.Models.ManagerHistory
{
    public class AddManagerHistoryModel
    {
        public int ManagerId { get; set; }
        public SelectList ManagerList { get; set; }
       
        public string TeamName { get; set; }
        public SelectList TeamList { get; set; }
        public string Season { get; set; }
        public SelectList SeasonList { get; set; }
        public string LeagueName { get; set; }
        public SelectList LeagueList { get; set; }

        public string Position { get; set; }
        public string Points { get; set; }
    }
}