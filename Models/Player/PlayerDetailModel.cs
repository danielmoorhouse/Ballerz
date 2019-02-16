using System;
using System.ComponentModel.DataAnnotations;

namespace Ballerz.Models.Player
{
    public class PlayerDetailModel
    {
        public string PlayerName { get; set; }

        [DataType(DataType.Date)]
        public DateTime DoB { get; set; }
        public string BirthPlace { get; set; }
        public string PlayerImageUrl { get; set; }
        public Ballerz.KnowledgeBase.Models.Players Players { get; set; }
         public Ballerz.KnowledgeBase.Models.Teams Teams { get; set; }
         public string TeamName { get; set; }
         public string TeamBadgeUrl { get; set; }
         public string CountryName { get; set; }
         public string FlagUrl { get; set; }
         public string Position { get; set; }
       //  public Ballerz.KnowledgeBase.Models.Positions Positions { get; set; }
         // public Ballerz.KnowledgeBase.Models.Countries Countries { get; set; }
    }
}