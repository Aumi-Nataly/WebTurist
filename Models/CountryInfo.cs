using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// Справочная информация о стране
    /// </summary>
    public class CountryInfo: CountriesList
    {
        public string language { get; set; }
        public string currencyName { get; set; }
        public string SummaryInfo { get; set; }

        public List<City> cities { get; set; }
    }
}
