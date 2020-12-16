using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using System.Threading.Tasks;

namespace BAIS3110_OAuth_Brendon_Lapp.Pages
{
    public class IndexModel : PageModel
    { 
        public string GitHubName { get; set; }
        public void OnGet()
        {
            if (User.Identity.IsAuthenticated)
            {
                GitHubName = User.Claims.Where(x => x.Type == "urn:github:login").Select(c => c.Value).SingleOrDefault();
            }
        }
    }
}
