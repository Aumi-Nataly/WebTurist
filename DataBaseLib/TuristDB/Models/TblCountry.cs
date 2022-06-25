using System;
using System.Collections.Generic;

namespace DataBaseLib.TuristDB.Models
{
    public partial class TblCountry
    {
        public TblCountry()
        {
            TblCities = new HashSet<TblCity>();
        }

        public int CountryId { get; set; }
        public string? CountryName { get; set; }
        public string? LanguageMain { get; set; }
        public bool? Visa { get; set; }
        public string? CurrencyName { get; set; }
        public string? SummaryInfo { get; set; }

        public virtual ICollection<TblCity> TblCities { get; set; }
    }
}
