using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebUI.Pages
{
    [Authorize]
    public class IdentityModel : PageModel
    {
        public void OnGet()
        {
            
        }
    }
}
