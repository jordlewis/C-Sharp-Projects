using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreApp.Pages
{
    public class TimeModel : PageModel
    {
        public DateTime ServTime { get; set; }
        public void OnGet()
        {
            ServTime = DateTime.Now;
        }

    }
}