using System;
using System.ComponentModel.DataAnnotations;

namespace Ballerz.Models.Player
{
    public class PlayerListingModel
    {
        public int Id { get; set; }
        public string PlayerName { get; set; }
        public string Birthplace { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DoB { get; set; }
         public string PlayerImageUrl { get; set; }
         public int PositionId { get; set; }
         public string Position { get; set; }
         public Ballerz.KnowledgeBase.Models.Positions Positions { get; set; }
         public string CountryName { get; set; }
         public string FlagUrl { get; set; }
         public int TeamId { get; set; }
         public string TeamName { get; set; }
    }
}