using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesMovie.Models;
using RazorPagesMovie.Services;

namespace RazorPagesMovie.Pages
{


    public class MailModel : PageModel
    {
        private readonly IMailService _mailService;

        [BindProperty]
        public Message message { get; set; }

        public MailModel(IMailService mailService)
        {
            _mailService = mailService;
        }

        public void OnGet()
        {

        }

        public async Task OnPost()
        {
            await _mailService.Send(message);
        }
    }
}