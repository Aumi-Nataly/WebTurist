using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract
{
    /// <summary>
    /// Получение информации о странах и городах
    /// </summary>
    public interface ICountryCity
    {
        /// <summary>
        /// Получить список стран для меню
        /// </summary>
        /// <returns></returns>
        public List<CountriesList> countriesLists();

    }
}
