#pragma checksum "C:\Users\Анон\source\repos\kirsan-sad\asp.net-curse\Layouts\Layouts\Views\Catalog\_GetCategories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e37ab5c3024382ddb1575b2fb61e48f85d677fdf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog__GetCategories), @"mvc.1.0.view", @"/Views/Catalog/_GetCategories.cshtml")]
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
#line 2 "C:\Users\Анон\source\repos\kirsan-sad\asp.net-curse\Layouts\Layouts\Views\_ViewImports.cshtml"
using Layouts.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e37ab5c3024382ddb1575b2fb61e48f85d677fdf", @"/Views/Catalog/_GetCategories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a40967c6a3b10cbf370f6a09cd57350c5f98e571", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalog__GetCategories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<string>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h3>Категории</h3>\r\n<ul>\r\n    <li><a href=\"Phones\">Phones</a></li>\r\n    <li><a href=\"Catalog/Cameras\">Cameras</a></li>\r\n    <li><a href=\"Catalog/Notebooks\">Notebooks</a></li>\r\n    <li><a href=\"Catalog/Headphoneses\">Headphoneses</a></li>\r\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<string>> Html { get; private set; }
    }
}
#pragma warning restore 1591
