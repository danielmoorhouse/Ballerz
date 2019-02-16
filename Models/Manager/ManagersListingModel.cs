using System;

namespace Ballerz.Models.Managers
{
    public class ManagersListingModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DoB { get; set;}
        public string ManagerImageUrl { get; set; }
        
        public string PlaceOfBirth { get; set; }
        public string CountryFlagUrl { get; set; }
        public string TeamBadge { get; set; }
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public Ballerz.KnowledgeBase.Models.Teams Teams { get; set; }
        

    }
}