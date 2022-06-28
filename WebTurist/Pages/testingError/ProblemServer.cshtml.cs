using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebTurist.Pages.testingError
{
    /// <summary>
    /// Моделирует внутреннюю ошибку
    /// </summary>
    public class ProblemServerModel : PageModel
    {
        public void OnGet()
        {
             throw new Exception("Ошибка на сервере");
        }
    }
}
