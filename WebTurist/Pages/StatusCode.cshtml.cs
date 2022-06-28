using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;

namespace WebTurist.Pages
{  
    public class StatusCodeModel : PageModel
    {

        public int OriginalStatusCode { get; set; }
        public string? OriginalPathAndQuery { get; set; }

        public string? ReasonPhrase { get; set; }

        public void OnGet(int statusCode)
        {

            OriginalStatusCode = statusCode;

            string reasonPhrase = ReasonPhrases.GetReasonPhrase(OriginalStatusCode);
            ReasonPhrase = reasonPhrase;

            var statusCodeReExecuteFeature = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
            if (statusCodeReExecuteFeature != null)
            {
                OriginalPathAndQuery =
                    statusCodeReExecuteFeature.OriginalPathBase
                    + statusCodeReExecuteFeature.OriginalPath
                    + statusCodeReExecuteFeature.OriginalQueryString;
            }
        }
    }
}
