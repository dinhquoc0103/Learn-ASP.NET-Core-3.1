using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication.Pages
{
    public class MultiformModel : PageModel
    {
        public string Message { get; set; } = "Initial Request";

        public void OnGet()
        {

        }
        public void OnPost()
        {
            this.Message = "Form Posted";
        }
        public void OnPostDelete()
        {
            this.Message = "Delete Handler Fired";
        }
        public void OnPostEdit()
        {
            this.Message = "Edit Handler Fired";
        }
        public void OnPostView()
        {
            this.Message = "View Handler Fired";
        }
    }
}