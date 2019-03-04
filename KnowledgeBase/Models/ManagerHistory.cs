namespace Ballerz.KnowledgeBase.Models
{
    public class ManagerHistory
    {
          public int Id { get; set; }
        public int ManagerId { get; set; }
         public int TeamId { get; set; }
         public string TeamName { get; set; }
        public Teams Teams { get; set; }
        public string Season { get; set; }
        public Seasons Seasons { get; set; }
        public string LeagueName { get; set; }
        public Leagues Leagues { get; set; }
        public string Position { get; set; }
        public string Points { get; set; }
    }
}