using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// Информация о городе
    /// </summary>
    public class City
    {
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public string cityName { get; set; }    
    }
}
