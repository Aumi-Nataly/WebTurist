using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebTurist.Models;

namespace WebTurist.Pages
{
    public class IndexModel : PageModel
    {
        public readonly List<CountriesList> countrylist;
        public IndexModel()
        {
            countrylist=new List<CountriesList>();
            countrylist.Add(new CountriesList { countryId = 1, countryName = "Россия" });
            countrylist.Add(new CountriesList { countryId = 2, countryName = "Греция" });
        }

        public void OnGet()
        {

        }
    }
}