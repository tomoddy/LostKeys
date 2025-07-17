using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LostKeys.Pages
{
    public class IndexModel : PageModel
    {
        public string? PhoneNumber { get; set; }

        public IndexModel() { }

        public void OnGet(string? number)
        {
            PhoneNumber = number;
        }
    }
}