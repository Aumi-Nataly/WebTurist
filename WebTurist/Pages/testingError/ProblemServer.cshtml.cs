using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebTurist.Pages.testingError
{
    /// <summary>
    /// ���������� ���������� ������
    /// </summary>
    public class ProblemServerModel : PageModel
    {
        public void OnGet()
        {
             throw new Exception("������ �� �������");
        }
    }
}
