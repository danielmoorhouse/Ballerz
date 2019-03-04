namespace Ballerz.Models.ClubHistory
{
    public class ClubHistoryListingModel
    {
          public int TeamId { get; set; }
          public string TeamName { get; set; }
        public string Season { get; set; }
        
        public string LeagueName { get; set; }
        public string Position { get; set; }
        public string Points { get; set; }
    }
}