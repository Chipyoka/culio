using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace culio.Pages.Zodiac;

public class SignsModel : PageModel
{
    private readonly ILogger<SignsModel> _logger;

    public SignsModel(ILogger<SignsModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
