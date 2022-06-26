using Contract;
using DataBaseLib.TuristDB.Models;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceData
{
    public class CountryCity : ICountryCity
    {

        private readonly TuristDBContext connect;

        public CountryCity(TuristDBContext _con)
        {
            connect = _con;
        }

        /// <summary>
        /// Получение списка стран из БД
        /// </summary>
        /// <returns></returns>  
        public List<CountriesList> countriesLists()
        {
            List<CountriesList> countries = new List<CountriesList>();

            var country = connect.TblCountries.Select(n => new { n.CountryId, n.CountryName });

            foreach (var l in country)
            {
                countries.Add(new CountriesList { countryId = l.CountryId, countryName = l.CountryName });
            }


            return countries;

        }

        public CountryInfo countryInfo(int id)
        {

            var c = connect.TblCountries.Where(n => n.CountryId == id).FirstOrDefault();

            return new CountryInfo()
            {
                language = c.LanguageMain,
                currencyName = c.CurrencyName,
                SummaryInfo = c.SummaryInfo,
                countryId = c.CountryId,
                countryName = c.CountryName
            };
        }
    }
}
