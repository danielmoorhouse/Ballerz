using System;
using System.ComponentModel.DataAnnotations;

namespace Ballerz.KnowledgeBase.Models
{
    public class Players
    {
        public int Id { get; set; }
        public int CountryId { get; set; }

        public string PlayerName { get; set; }
        public string Birthplace { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DoB { get; set; }
        public int TeamId { get; set; }
        public int PositionId { get; set; }
        public string Position { get; set; }
        public Positions Positions { get; set; }
        public string PlayerImageUrl {get; set; }
       
    }
}