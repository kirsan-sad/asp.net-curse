#pragma checksum "C:\Users\Анон\source\repos\kirsan-sad\asp.net-curse\Layouts\Layouts\Views\Home\_GetSessionValue.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68e3555f6bf710bee004024bbd649d5716de00e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__GetSessionValue), @"mvc.1.0.view", @"/Views/Home/_GetSessionValue.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Анон\source\repos\kirsan-sad\asp.net-curse\Layouts\Layouts\Views\Home\_GetSessionValue.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68e3555f6bf710bee004024bbd649d5716de00e9", @"/Views/Home/_GetSessionValue.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a40967c6a3b10cbf370f6a09cd57350c5f98e571", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__GetSessionValue : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Анон\source\repos\kirsan-sad\asp.net-curse\Layouts\Layouts\Views\Home\_GetSessionValue.cshtml"
Write(GetSessionText());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\Users\Анон\source\repos\kirsan-sad\asp.net-curse\Layouts\Layouts\Views\Home\_GetSessionValue.cshtml"
 
    public string GetSessionText()
    {
        var name = Context.Session.GetString("Name");
        return !string.IsNullOrEmpty(name) ? $"Добро пожаловать, {name}" : string.Empty;
    }

#line default
#line hidden
#nullable disable
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
