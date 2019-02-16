namespace Ballerz.Models.Leagues
{
    public class LeagueListingModel
    {
        public int Id { get; set; }
        public string LeagueName { get; set; }
        public string LeagueImageUrl { get; set; }
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        
    }
}