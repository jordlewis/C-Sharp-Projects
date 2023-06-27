using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreApp.Pages
{
    public class TimeModel : PageModel
    {
        // 
        public DateTime ServTime { get; set; }
        // This is called when the page is loaded
        public void OnGet()
        {
            // And set's the variable 'ServTime' to the current server time
            ServTime = DateTime.Now;
        }

    }
}