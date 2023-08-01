using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace udemy.Pages;

[Authorize(Policy = "MustBelongToHrDepartment")]
public class HumanResourceModel : PageModel
{
    public void OnGet()
    {
    }
}
