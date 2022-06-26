using Contract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;

namespace WebTurist.Pages
{
    public class IndexModel : PageModel
    {
        public List<CountriesList> countrylist { get; set; }
        private readonly ICountryCity country;
        public IndexModel(ICountryCity _country)
        {
            country = _country;
            countrylist = new List<CountriesList>();

        }

        public void OnGet()
        {
            countrylist = country.countriesLists();
        }
    }
}