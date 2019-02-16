using System;

namespace Ballerz.Models.Manager
{
    public class ManagerDetailModel
    {
        public int Id { get; set; }
        public string ManagerName { get; set; }
        public DateTime DoB { get; set;}
        public string ManagerImageUrl { get; set; }
        
        public string PlaceOfBirth { get; set; }
        public string CountryId { get; set; }
        public string CountryName { get; set; }
        public string FlagUrl { get; set; }
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public string TeamBadgeUrl { get; set; }
    }
}