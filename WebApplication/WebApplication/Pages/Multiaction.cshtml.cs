using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication.Pages
{
    public class MultiactionModel : PageModel
    {
        public string Message { get; set; } = "Default GET method";
        public void OnPostRegister()
        {
            this.Message = "Post Register Fired!";
        }

        public void OnPostRequestInfo()
        {
            this.Message = "Post Request Info Fired!";
        }
        public void OnGetClear()
        {
            this.Message = "Get Clear Fired!";
        }
        public void OnGetReset()
        {
            this.Message = "Get Reset Fired!";
        }
    }
}
