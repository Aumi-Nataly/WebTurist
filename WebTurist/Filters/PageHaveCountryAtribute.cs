using Contract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebTurist.Filters
{
    /// <summary>
    /// Фильтр страницы вывода инфы о стране. Проверяет наличие страны в базе по коду
    /// </summary>
    public class PageHaveCountryAtribute : Attribute, IPageFilter
    {
        private readonly ICountryCity country;

        public PageHaveCountryAtribute(ICountryCity _country)
        {
            country= _country;  
        }

        /// <summary>
        /// Выполняется после выполнения обработчика страницы
        /// </summary>
        /// <param name="context"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void OnPageHandlerExecuted(PageHandlerExecutedContext context)
        {
            
        }

        /// <summary>
        /// Выполняется после привязки модели и перед выполнением обработчика
        /// </summary>
        /// <param name="context"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {
            var countryId = (int)context.HandlerArguments["id"];

            if (!country.countryExists(countryId))
                context.Result = new NotFoundResult();
        }

        /// <summary>
        /// Выполняется после выбора обработчика перед привязкой модели
        /// </summary>
        /// <param name="context"></param>
        public void OnPageHandlerSelected(PageHandlerSelectedContext context)
        {
            
        }
    }
}
