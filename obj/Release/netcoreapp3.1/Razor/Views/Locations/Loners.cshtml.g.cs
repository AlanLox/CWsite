#pragma checksum "C:\Users\Dell\source\repos\CWsite\Views\Locations\Loners.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92f53261cfc64b9d35fe004bfb9cd9c7fa6dd131"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Locations_Loners), @"mvc.1.0.view", @"/Views/Locations/Loners.cshtml")]
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
#line 1 "C:\Users\Dell\source\repos\CWsite\Views\_ViewImports.cshtml"
using CWsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dell\source\repos\CWsite\Views\_ViewImports.cshtml"
using CWsite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92f53261cfc64b9d35fe004bfb9cd9c7fa6dd131", @"/Views/Locations/Loners.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fea7d5e0fb9d48f355301391b750e875aed85f31", @"/Views/_ViewImports.cshtml")]
    public class Views_Locations_Loners : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("../Locations/Message?loc=6"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin: 0 7%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\Dell\source\repos\CWsite\Views\Locations\Loners.cshtml"
  
    ViewData["Title"] = "Нейтральная территория";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <div>
        <h1>Нейтральная территория</h1>
        <div style=""margin: 0 10%;"">
            <img src=""../images/Нейтральная.jpeg"" style=""width: 100%"">
        </div>
        <p>Территория, граничащая с людскими поселениями. Здесь обитают одиночки, а так же домашние коты.</p>
        <p style=""color: black; text-align: center;""><b>Соседние локации:</b></p>
        <ul class=""List"" style=""margin: 0 150px"">
            <li class=""menuLi""><a class=""Link"" href=""../Locations/ThunderClan"" style=""padding: 5px;"">Территория грозового племени</a></li>
            <li class=""menuLi""><a class=""Link"" href=""../Locations/RiverClan"" style=""padding: 5px;"">Территория речного племени</a></li>
            <li class=""menuLi""><a class=""Link"" href=""../Locations/WindClan"" style=""padding: 5px;"">Территория племени ветра</a></li>
            <li class=""menuLi""><a class=""Link"" href=""../Locations/ShadowClan"" style=""padding: 5px;"">Территория племени теней</a></li>
        </ul>
        <br />

");
#nullable restore
#line 21 "C:\Users\Dell\source\repos\CWsite\Views\Locations\Loners.cshtml"
         if (Context.Session.Keys.Contains("author"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92f53261cfc64b9d35fe004bfb9cd9c7fa6dd1315686", async() => {
                WriteLiteral("\r\n                <br />\r\n                Ваш пост: <br /><textarea type=\"text\" name=\"message\" style=\"width: 700px; height: 100px;\"></textarea>\r\n                <br />\r\n                <input type=\"submit\" value=\"Отправить\" />\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 29 "C:\Users\Dell\source\repos\CWsite\Views\Locations\Loners.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <p>Для участия в ролевой войдите или зарегестрируйтесь.</p>");
#nullable restore
#line 31 "C:\Users\Dell\source\repos\CWsite\Views\Locations\Loners.cshtml"
                                                                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n\r\n");
#nullable restore
#line 36 "C:\Users\Dell\source\repos\CWsite\Views\Locations\Loners.cshtml"
 foreach (var p in CWsite.Models.PostModel.GetPosts("Loners"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <div style=\"background-position: center; background-color: #fff0e5; \">\r\n        <span style=\"font: bold\">");
#nullable restore
#line 40 "C:\Users\Dell\source\repos\CWsite\Views\Locations\Loners.cshtml"
                            Write(p.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <br />\r\n        <span>");
#nullable restore
#line 42 "C:\Users\Dell\source\repos\CWsite\Views\Locations\Loners.cshtml"
         Write(p.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <p>");
#nullable restore
#line 43 "C:\Users\Dell\source\repos\CWsite\Views\Locations\Loners.cshtml"
      Write(p.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n");
#nullable restore
#line 45 "C:\Users\Dell\source\repos\CWsite\Views\Locations\Loners.cshtml"
}

#line default
#line hidden
#nullable disable
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
