#pragma checksum "C:\Users\Анон\source\repos\kirsan-sad\asp.net-curse\Layouts\Layouts\Views\Catalog\Cameras.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b7d65e9d2803c93b87dc371d8408d528b5cc8bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog_Cameras), @"mvc.1.0.view", @"/Views/Catalog/Cameras.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\Анон\source\repos\kirsan-sad\asp.net-curse\Layouts\Layouts\Views\_ViewImports.cshtml"
using Layouts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Анон\source\repos\kirsan-sad\asp.net-curse\Layouts\Layouts\Views\Catalog\Cameras.cshtml"
using Layouts.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b7d65e9d2803c93b87dc371d8408d528b5cc8bd", @"/Views/Catalog/Cameras.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a40967c6a3b10cbf370f6a09cd57350c5f98e571", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalog_Cameras : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Анон\source\repos\kirsan-sad\asp.net-curse\Layouts\Layouts\Views\Catalog\Cameras.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <nav class=\"col-xl-2\">\r\n        ");
#nullable restore
#line 6 "C:\Users\Анон\source\repos\kirsan-sad\asp.net-curse\Layouts\Layouts\Views\Catalog\Cameras.cshtml"
   Write(await Html.PartialAsync("_GetCategories"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </nav>
<article class=""col-md-14 col-xl-10"">
    <div class=""text-center"">
        <h1 class=""display-4"">All cameras in catalog</h1>
        <p>
            <table border='1'>
                <tr><th>Id</th><th>Brand</th><th>Model</th><th>Price</th></tr>
");
#nullable restore
#line 14 "C:\Users\Анон\source\repos\kirsan-sad\asp.net-curse\Layouts\Layouts\Views\Catalog\Cameras.cshtml"
                 foreach (Cameras item in ViewBag.Content)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 17 "C:\Users\Анон\source\repos\kirsan-sad\asp.net-curse\Layouts\Layouts\Views\Catalog\Cameras.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 18 "C:\Users\Анон\source\repos\kirsan-sad\asp.net-curse\Layouts\Layouts\Views\Catalog\Cameras.cshtml"
               Write(item.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\Анон\source\repos\kirsan-sad\asp.net-curse\Layouts\Layouts\Views\Catalog\Cameras.cshtml"
               Write(item.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\Анон\source\repos\kirsan-sad\asp.net-curse\Layouts\Layouts\Views\Catalog\Cameras.cshtml"
               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 22 "C:\Users\Анон\source\repos\kirsan-sad\asp.net-curse\Layouts\Layouts\Views\Catalog\Cameras.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </table>\r\n         </p>\r\n     </div>\r\n</article>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
