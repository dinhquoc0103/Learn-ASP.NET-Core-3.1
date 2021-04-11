using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public string Title { get; private set; }
        public string Text { get; private set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        // Sử dụng tham số của hàm truy vấn OnPost để nhận dữ liệu từ thuộc tính name khi form submit
        //public void OnPost(string title, string text)
        //{
        //    this.Title = title;
        //    this.Text = text;
        //}

        // Hoặc cũng có thể nhận giá trị từ form thông qua thuộc tính name bằng cách sử dụng thuộc tính Form của đối tượng Request
        public void OnPost()
        {
            this.Title = Request.Form["title"];
            this.Text = Request.Form["text"];
        }


    }
}
