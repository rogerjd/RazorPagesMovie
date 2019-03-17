using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages
{
    public class AboutModel : PageModel
    {
        private IClock _clock;
        public string Message;

        public AboutModel(IClock clock)
        {
            _clock = clock;
        }

        public void OnGet()
        {
            Message = _clock.GetTime();
        }
    }
}