using Microsoft.AspNetCore.Http;

namespace Ballerz.Models.Countries
{
    public class CountriesListingModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FlagUrl { get; set; }
        
    }
}