#pragma checksum "D:\Learn ASP.NET Core\S02_RazorPages\P02_RazorApp\Pages\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db6a566b1b06da5d9b2d2d9efcc4400623cc2e6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(P02_RazorApp.Pages.Pages_About), @"mvc.1.0.razor-page", @"/Pages/About.cshtml")]
namespace P02_RazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Learn ASP.NET Core\S02_RazorPages\P02_RazorApp\Pages\_ViewImports.cshtml"
using P02_RazorApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db6a566b1b06da5d9b2d2d9efcc4400623cc2e6c", @"/Pages/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b67293da51987014d58310b07d7bd6ce6de7132", @"/Pages/_ViewImports.cshtml")]
    public class Pages_About : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Learn ASP.NET Core\S02_RazorPages\P02_RazorApp\Pages\About.cshtml"
  
    // Layout = "_Layout";
    ViewData["Title"] = "About";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 7 "D:\Learn ASP.NET Core\S02_RazorPages\P02_RazorApp\Pages\About.cshtml"
Write(SayHello("Covid"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<p>It\'s ");
#nullable restore
#line 9 "D:\Learn ASP.NET Core\S02_RazorPages\P02_RazorApp\Pages\About.cshtml"
   Write(DateTime.Now.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>

<p>ASP.NET Core Razor Pages is a page-focused framework for building dynamic, data-driven web sites with clean separation of concerns. Based on the latest version of ASP.NET from Microsoft - ASP.NET Core, Razor Pages supports cross platform development and can be deployed to Windows, Unix and Mac operating systems.</p>

");
#nullable restore
#line 13 "D:\Learn ASP.NET Core\S02_RazorPages\P02_RazorApp\Pages\About.cshtml"
  
    string SayHello(string name)
    {
        return $"Hello, {name}. Welcome to Razor Pages!";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(" \r\n    <script>\r\n        $(document).ready(function () {\r\n            alert(\'page about\');\r\n        });\r\n    </script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_About> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_About> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_About>)PageContext?.ViewData;
        public Pages_About Model => ViewData.Model;
    }
}
#pragma warning restore 1591
