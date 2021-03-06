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


        /// <summary>
        /// Информация по указанной стране
        /// </summary>
        /// <param name="id">id страны</param>
        /// <returns></returns>
        public CountryInfo countryInfo(int id);

        /// <summary>
        /// Проверка на наличие страны по коду
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool countryExists(int id);

    }
}
