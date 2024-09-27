using FreeBilling.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FreeBilling.Web.Pages
{
    public class ContactsModel : PageModel
    {
        public string Title { get; set; } = "Contact Me";
        public string Message { get; set; } = "";
        
        [BindProperty]
        public ContactViewModel Contact { get; set; } = new ContactViewModel();
        public void OnGet()
        {
        }

        public void OnPost()
        {
            Message = "Not implemented";
        }
    }
}
