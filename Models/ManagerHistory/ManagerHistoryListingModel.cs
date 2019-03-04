namespace Ballerz.Models.ManagerHistory
{
    public class ManagerHistoryListingModel
    {
        public string Id { get; set; }
      public int ManagerId { get; set; }
        public string ManagerName { get; set; }
         public string TeamName { get; set; }
        public string Season { get; set; }
        
        public string LeagueName { get; set; }
        public string Position { get; set; }
        public string Points { get; set; }
    }
}