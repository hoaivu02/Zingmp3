#pragma checksum "C:\Users\hoaiv\source\repos\ZingM3p\ZingM3p\Views\Music\_ViewAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43659394241622fa15343406ba0a1a14ef7cf4fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Music__ViewAll), @"mvc.1.0.view", @"/Views/Music/_ViewAll.cshtml")]
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
#line 1 "C:\Users\hoaiv\source\repos\ZingM3p\ZingM3p\Views\_ViewImports.cshtml"
using ZingM3p;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hoaiv\source\repos\ZingM3p\ZingM3p\Views\_ViewImports.cshtml"
using ZingM3p.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43659394241622fa15343406ba0a1a14ef7cf4fc", @"/Views/Music/_ViewAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8032e7c4b5d325a78ff60677235a999e4b2f7b1d", @"/Views/_ViewImports.cshtml")]
    public class Views_Music__ViewAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ZingM3p.Models.MusicModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return jQueryAjaxDelete(this);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 7 "C:\Users\hoaiv\source\repos\ZingM3p\ZingM3p\Views\Music\_ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.MusicName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 10 "C:\Users\hoaiv\source\repos\ZingM3p\ZingM3p\Views\Music\_ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.ArtistName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\hoaiv\source\repos\ZingM3p\ZingM3p\Views\Music\_ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\hoaiv\source\repos\ZingM3p\ZingM3p\Views\Music\_ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.Views));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 531, "\"", 635, 4);
            WriteAttributeValue("", 541, "showInPopup(\'", 541, 13, true);
#nullable restore
#line 19 "C:\Users\hoaiv\source\repos\ZingM3p\ZingM3p\Views\Music\_ViewAll.cshtml"
WriteAttributeValue("", 554, Url.Action("AddOrEdit","Music",new { id=0}, Context.Request.Scheme), 554, 68, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 622, "\',\'New", 622, 6, true);
            WriteAttributeValue(" ", 628, "Song\')", 629, 7, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success text-white\"><i class=\"fas fa-random\"></i> New Song</a>\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 24 "C:\Users\hoaiv\source\repos\ZingM3p\ZingM3p\Views\Music\_ViewAll.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 28 "C:\Users\hoaiv\source\repos\ZingM3p\ZingM3p\Views\Music\_ViewAll.cshtml"
               Write(Html.DisplayFor(modelItem => item.MusicName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 31 "C:\Users\hoaiv\source\repos\ZingM3p\ZingM3p\Views\Music\_ViewAll.cshtml"
               Write(Html.DisplayFor(modelItem => item.ArtistName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 34 "C:\Users\hoaiv\source\repos\ZingM3p\ZingM3p\Views\Music\_ViewAll.cshtml"
               Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 37 "C:\Users\hoaiv\source\repos\ZingM3p\ZingM3p\Views\Music\_ViewAll.cshtml"
               Write(Html.DisplayFor(modelItem => item.Views));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1328, "\"", 1449, 4);
            WriteAttributeValue("", 1338, "showInPopup(\'", 1338, 13, true);
#nullable restore
#line 40 "C:\Users\hoaiv\source\repos\ZingM3p\ZingM3p\Views\Music\_ViewAll.cshtml"
WriteAttributeValue("", 1351, Url.Action("AddOrEdit","Music",new { id = item.MusicId }, Context.Request.Scheme), 1351, 82, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1433, "\',\'Update", 1433, 9, true);
            WriteAttributeValue(" ", 1442, "Song\')", 1443, 7, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info text-white\"><i class=\"fas fa-pencil-alt\"></i> Edit</a>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43659394241622fa15343406ba0a1a14ef7cf4fc8713", async() => {
                WriteLiteral("\r\n                        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "C:\Users\hoaiv\source\repos\ZingM3p\ZingM3p\Views\Music\_ViewAll.cshtml"
                                                WriteLiteral(item.MusicId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 46 "C:\Users\hoaiv\source\repos\ZingM3p\ZingM3p\Views\Music\_ViewAll.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
    <iframe width=""600""
            height=""400""
            seamless
            frameBorder=""0""
            scrolling=""no""
            src=""http://10.163.23.32:8088/superset/explore/p/Wd4XBwV6o7z/?standalone=1&height=400"">
    </iframe>
</table>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ZingM3p.Models.MusicModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
