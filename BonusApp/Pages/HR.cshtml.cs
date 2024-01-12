using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BonusApp.Pages
{
    [Authorize(Policy = "MustBelongToHR")]
    public class HRModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
