using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Ballerz.KnowledgeBase.Models;

namespace Ballerz.Models.Player
{
    public class PlayerDetailModel
    {
      public int Id { get; set; }
        public string PlayerName { get; set; }

        [DataType(DataType.Date)]
        public DateTime DoB { get; set; }
        public string BirthPlace { get; set; }
        public string PlayerImageUrl { get; set; }
        public string CurrentValue { get; set; }
        public Ballerz.KnowledgeBase.Models.Players Players { get; set; }
         public Ballerz.KnowledgeBase.Models.Teams Teams { get; set; }
         public string TeamName { get; set; }
         public string TeamBadgeUrl { get; set; }
         public string CountryName { get; set; }
         public string FlagUrl { get; set; }
         public string Position { get; set; }
         public IEnumerable<Ballerz.KnowledgeBase.Models.PlayerHistory> PlayerHistory { get; set; }
       //  public Ballerz.KnowledgeBase.Models.Positions Positions { get; set; }
         // public Ballerz.KnowledgeBase.Models.Countries Countries { get; set; }
    }
}