using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Model_Class.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{this.FirstName} {this.LastName}";
        [ViewData]
        public string Message { get; set; }

        public string SayGoodbye() => $"Hello, {this.FullName}! I'm in the Model Class";

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            this.FirstName = "Donald";
            this.LastName = "Donald";

            // Index.cshtml.cs

                ViewData["MyNumber"] = 2020;
                ViewData["MyString"] = "Hello World, Razor Pages!";
            //ViewData["MyObject"] = new Book
            //{
            //    Title = "ASP.NET Core for Dummy",
            //    Publisher = "Tự học ICT Press",
            //    Author = "Mai Chi"
            //};

            this.Message = "Hello lo";
       
        }
    }
}
