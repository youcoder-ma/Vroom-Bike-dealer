#pragma checksum "C:\Users\Youcode\Desktop\Projects\Vroom-Bike-dealer\App\Vroom\Vroom\Views\Bike\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc20cdacdff4c34d5ed617e4ed889d74caaef22f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bike_Index), @"mvc.1.0.view", @"/Views/Bike/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Bike/Index.cshtml", typeof(AspNetCore.Views_Bike_Index))]
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
#line 1 "C:\Users\Youcode\Desktop\Projects\Vroom-Bike-dealer\App\Vroom\Vroom\Views\_ViewImports.cshtml"
using Vroom;

#line default
#line hidden
#line 2 "C:\Users\Youcode\Desktop\Projects\Vroom-Bike-dealer\App\Vroom\Vroom\Views\_ViewImports.cshtml"
using Vroom.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc20cdacdff4c34d5ed617e4ed889d74caaef22f", @"/Views/Bike/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2175c317c0f601321dc2a899abbe338f18e18a24", @"/Views/_ViewImports.cshtml")]
    public class Views_Bike_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Vroom.Models.Bike>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_TableButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Youcode\Desktop\Projects\Vroom-Bike-dealer\App\Vroom\Vroom\Views\Bike\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(127, 151, true);
            WriteLiteral("\r\n<br />\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <h2 class=\"text-info\">Bikes</h2>\r\n    </div>\r\n    <div class=\"col-6 float-end\">\r\n        ");
            EndContext();
            BeginContext(278, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad2c60aed9c643b38fee6a2a79373bfd", async() => {
                BeginContext(322, 53, true);
                WriteLiteral("<i class=\"fas fa-motorcycle\"></i> &nbsp; Add New Bike");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(379, 339, true);
            WriteLiteral(@"
    </div>
    <br />
    <div class=""col-12"">
        <table class=""table table-striped border"">
            <tr class=""table-info"">
                <th>Bike Photo</th>
                <th>Bike Detail</th>
                <th>Price</th>
                <th>Seller information</th>
                <th></th>
            </tr>
");
            EndContext();
#line 25 "C:\Users\Youcode\Desktop\Projects\Vroom-Bike-dealer\App\Vroom\Vroom\Views\Bike\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(775, 50, true);
            WriteLiteral("                <tr>\r\n                    <td><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 825, "\"", 866, 1);
#line 28 "C:\Users\Youcode\Desktop\Projects\Vroom-Bike-dealer\App\Vroom\Vroom\Views\Bike\Index.cshtml"
WriteAttributeValue("", 831, Html.DisplayFor(m=>item.ImagePath), 831, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(867, 91, true);
            WriteLiteral(" width=\"150px\" height=\"100px\"/></td>\r\n                    <td>\r\n                        <b>");
            EndContext();
            BeginContext(959, 34, false);
#line 30 "C:\Users\Youcode\Desktop\Projects\Vroom-Bike-dealer\App\Vroom\Vroom\Views\Bike\Index.cshtml"
                      Write(Html.DisplayFor(m=>item.Make.Name));

#line default
#line hidden
            EndContext();
            BeginContext(993, 2, true);
            WriteLiteral(" (");
            EndContext();
            BeginContext(996, 29, false);
#line 30 "C:\Users\Youcode\Desktop\Projects\Vroom-Bike-dealer\App\Vroom\Vroom\Views\Bike\Index.cshtml"
                                                           Write(Html.DisplayFor(m=>item.Year));

#line default
#line hidden
            EndContext();
            BeginContext(1025, 49, true);
            WriteLiteral("</b><br/>\r\n                        <b>Model: </b>");
            EndContext();
            BeginContext(1075, 35, false);
#line 31 "C:\Users\Youcode\Desktop\Projects\Vroom-Bike-dealer\App\Vroom\Vroom\Views\Bike\Index.cshtml"
                                 Write(Html.DisplayFor(m=>item.Model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1110, 50, true);
            WriteLiteral(" <br />\r\n                        <b>Milleage :</b>");
            EndContext();
            BeginContext(1161, 33, false);
#line 32 "C:\Users\Youcode\Desktop\Projects\Vroom-Bike-dealer\App\Vroom\Vroom\Views\Bike\Index.cshtml"
                                    Write(Html.DisplayFor(m=>item.Milleage));

#line default
#line hidden
            EndContext();
            BeginContext(1194, 53, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>");
            EndContext();
            BeginContext(1248, 30, false);
#line 34 "C:\Users\Youcode\Desktop\Projects\Vroom-Bike-dealer\App\Vroom\Vroom\Views\Bike\Index.cshtml"
                   Write(Html.DisplayFor(m=>item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1278, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1280, 33, false);
#line 34 "C:\Users\Youcode\Desktop\Projects\Vroom-Bike-dealer\App\Vroom\Vroom\Views\Bike\Index.cshtml"
                                                   Write(Html.DisplayFor(m=>item.Currency));

#line default
#line hidden
            EndContext();
            BeginContext(1313, 70, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        <b>Name: </b>");
            EndContext();
            BeginContext(1384, 35, false);
#line 36 "C:\Users\Youcode\Desktop\Projects\Vroom-Bike-dealer\App\Vroom\Vroom\Views\Bike\Index.cshtml"
                                Write(Html.DisplayFor(m=>item.SellerName));

#line default
#line hidden
            EndContext();
            BeginContext(1419, 46, true);
            WriteLiteral("<br />\r\n                        <b>Email: </b>");
            EndContext();
            BeginContext(1466, 36, false);
#line 37 "C:\Users\Youcode\Desktop\Projects\Vroom-Bike-dealer\App\Vroom\Vroom\Views\Bike\Index.cshtml"
                                 Write(Html.DisplayFor(m=>item.SellerEmail));

#line default
#line hidden
            EndContext();
            BeginContext(1502, 46, true);
            WriteLiteral("<br />\r\n                        <b>Phone: </b>");
            EndContext();
            BeginContext(1549, 36, false);
#line 38 "C:\Users\Youcode\Desktop\Projects\Vroom-Bike-dealer\App\Vroom\Vroom\Views\Bike\Index.cshtml"
                                 Write(Html.DisplayFor(m=>item.SellerPhone));

#line default
#line hidden
            EndContext();
            BeginContext(1585, 49, true);
            WriteLiteral("\r\n                    </td>\r\n                    ");
            EndContext();
            BeginContext(1634, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e4bbe238e05b4bf3a8695d696b48417e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 40 "C:\Users\Youcode\Desktop\Projects\Vroom-Bike-dealer\App\Vroom\Vroom\Views\Bike\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1687, 25, true);
            WriteLiteral("\r\n                </tr>\r\n");
            EndContext();
#line 42 "C:\Users\Youcode\Desktop\Projects\Vroom-Bike-dealer\App\Vroom\Vroom\Views\Bike\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1727, 40, true);
            WriteLiteral("        </table>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Vroom.Models.Bike>> Html { get; private set; }
    }
}
#pragma warning restore 1591
