using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string message;

        public IndexModel(ILogger<IndexModel> logger)
        {
            message = "Люблю мужа почти на 100 из 100";
           
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}