using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AzureDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            _logger.LogCritical("This is my test for critical log messages. Alejo");
            _logger.LogError("This is my test for error log messages. Alejo");
            _logger.LogWarning("This is my test for warning log messages. Alejo");
        }
    }
}
