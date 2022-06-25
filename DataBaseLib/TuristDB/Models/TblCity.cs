using System;
using System.Collections.Generic;

namespace DataBaseLib.TuristDB.Models
{
    public partial class TblCity
    {
        public TblCity()
        {
            TblInterestPointCities = new HashSet<TblInterestPointCity>();
        }

        public int CityId { get; set; }
        public int? CountryId { get; set; }
        public string? CityName { get; set; }

        public virtual TblCountry? Country { get; set; }
        public virtual ICollection<TblInterestPointCity> TblInterestPointCities { get; set; }
    }
}
