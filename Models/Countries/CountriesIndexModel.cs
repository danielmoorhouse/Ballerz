using System.Collections.Generic;

namespace Ballerz.Models.Countries
{
    public class CountriesIndexModel
    {
        public IEnumerable<CountriesListingModel> CountriesList { get; set; }
    }
}