using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace P02_RazorApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages()
                    .AddRazorPagesOptions(options => {
                        options.RootDirectory = "/Content";  // Thay đổi root folder Pages thành Content
                        // Thay đổi home page mặc định nếu(tức là thay index mặc định mọi người thành home. Nếu tồn tại index.cshtml thì vẫn ưu tiên và sẽ gây lỗi nếu cấu hình)
                        options.Conventions.AddPageRoute("/Home", "/");
                        // Ánh xạ /blogpost đến /Member/Vip/Index tưc là khi đánh trên url /blogpost sẽ tự chuyển đến file của đường dẫn /Member/Vip/Index
                        options.Conventions.AddPageRoute("/Member/Vip/Index", "/blogpost");
                        //Có thể ánh xạ nhiều url mới đến một url cũ (định nghĩa nhiều route tới cùng một page)
                        options.Conventions.AddPageRoute("/member/vip/index", "/member-vip");
                    });    
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
