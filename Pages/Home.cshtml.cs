using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ChattingWebApp.Pages
{
    public class HomeModel : PageModel
    {
        public string userName { get; set; }
        private static int _userCount = 0;

        private readonly ILogger<HomeModel> _logger;

        public HomeModel(ILogger<HomeModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnGet(string username)
        {
            if (_userCount < 5)
            {
                _userCount++;

                if (string.IsNullOrEmpty(username))
                {
                    return RedirectToPage("/Index");
                }
                else
                {
                    userName = username;
                    return Page();
                }



            }
            else
            {
                return RedirectToPage("/Index");
            }


        }
    }
}
