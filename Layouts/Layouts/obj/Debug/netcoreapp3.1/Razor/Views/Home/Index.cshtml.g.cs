#pragma checksum "C:\Users\User\Documents\GitHub\asp.net-curse\Layouts\Layouts\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3335d28482a48448173d6b9df5ddf8606a004d7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\User\Documents\GitHub\asp.net-curse\Layouts\Layouts\Views\_ViewImports.cshtml"
using Layouts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Documents\GitHub\asp.net-curse\Layouts\Layouts\Views\_ViewImports.cshtml"
using Layouts.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3335d28482a48448173d6b9df5ddf8606a004d7a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a40967c6a3b10cbf370f6a09cd57350c5f98e571", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\User\Documents\GitHub\asp.net-curse\Layouts\Layouts\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<nav class=\"col-xl-2\">\r\n    ");
#nullable restore
#line 5 "C:\Users\User\Documents\GitHub\asp.net-curse\Layouts\Layouts\Views\Home\Index.cshtml"
Write(await Html.PartialAsync("_GetCategories"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</nav>\r\n<article class=\"col-md-14 col-xl-10\">\r\n    <div class=\"text-center\">\r\n        <h1 class=\"display-4\">Welcome</h1>\r\n        <h2>Введите имя</h2>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3335d28482a48448173d6b9df5ddf8606a004d7a4535", async() => {
                WriteLiteral("\r\n            <div class=\"text-center\">\r\n                <p><input type=\"text\" name=\"name\" /></p>\r\n                <p><input type=\"submit\" value=\"Submit\" /></p>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <p>
            Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur dapibus interdum neque et imperdiet. Duis augue diam, interdum nec eros ac, sagittis consectetur neque. Donec orci metus, congue nec ligula eu, mattis lobortis mi. Mauris et augue ultrices, efficitur nulla ultrices, viverra magna. Sed in magna quis arcu euismod tincidunt tempus nec lacus. In eget tellus in est fermentum tempor lobortis vitae quam. Maecenas hendrerit non ipsum varius ultricies.
        </p>
        <p>
            Curabitur congue non massa vel pretium. Pellentesque quis metus purus. Suspendisse at ligula eu felis vestibulum pellentesque in eu elit. Ut est est, vestibulum placerat eros vel, euismod cursus odio. Ut imperdiet sed leo at porta. Morbi aliquam sit amet magna eu molestie. Praesent aliquet urna dolor, a condimentum dui pretium ultricies. Nulla lacinia commodo leo ut auctor. Phasellus eu libero vitae lectus facilisis dictum. Praesent est nulla, commodo in lacus sit amet, ullamcorper congue");
            WriteLiteral(@" neque. Aenean ac venenatis odio. Donec eget sem lectus. Integer convallis nisl ac dui tristique efficitur. Sed tristique molestie lectus sit amet pretium. Ut ut condimentum lorem.
        </p>
        <p>
            Praesent posuere ex sit amet tincidunt luctus. Integer mattis in orci sed rutrum. Praesent suscipit felis justo, ut egestas nunc ultricies ut. Pellentesque vel semper justo. Proin facilisis neque quis vehicula mattis. Donec a mi a purus bibendum mattis ac vel turpis. Morbi ac sapien non sapien mattis venenatis. Pellentesque sit amet vehicula eros. Sed vestibulum erat blandit malesuada scelerisque. Nulla lectus tellus, condimentum eu leo laoreet, porttitor pulvinar arcu. Nullam ut luctus dui. Curabitur a pretium neque, et rutrum mauris. Aliquam eget rhoncus justo. In hac habitasse platea dictumst. Praesent vitae quam mollis, finibus magna a, mollis augue.
        </p>
    </div>
</article>
");
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
