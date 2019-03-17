using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesMovie.Pages
{
    public class TestModel : PageModel
    {
        private readonly RazorPagesMovie.Models.RazorPagesMovieContext _context;

        public string Message { get; set; } = "Initial Request";


        public TestModel(RazorPagesMovie.Models.RazorPagesMovieContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            Message = "Form Posted";
        }

        public void OnPostEdit()
        {
            Message = "Edit handler fired";
        }

        public void OnPostDelete()
        {
            Message = "Delete handler fired";
        }

        //ref: there must be a ctrl in the form with name="id" for the param to bind
        public void OnPostView(int id)
        {
            Message = $"View handler fired with value = {id}";
        }

    }
}