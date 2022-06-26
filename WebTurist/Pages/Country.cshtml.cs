using Contract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;

namespace WebTurist.Pages
{
    public class CountryModel : PageModel
    {
        public CountryInfo cinfo { get; set; }
        private readonly ICountryCity country;

        public CountryModel(ICountryCity _country)
        {
            country= _country;
        }

        public void OnGet(int id)
        {
            cinfo = country.countryInfo(id);
        }
    }
}
