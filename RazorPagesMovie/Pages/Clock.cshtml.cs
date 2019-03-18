using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages
{
    public class ClockModel : PageModel
    {
        private IClock _clock;
        public string Message;

        public ClockModel(IClock clock)
        {
            _clock = clock;
        }

        public void OnGet()
        {
            Message = _clock.GetTime();
        }
    }
}