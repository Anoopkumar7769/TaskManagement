#pragma checksum "C:\Users\237598\Desktop\ASP.NET Web Applications\TaskManagement\TaskManagement\Views\Record\GetData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f3133d480d2ed09114af9ac43f3e3a682d08db9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Record_GetData), @"mvc.1.0.view", @"/Views/Record/GetData.cshtml")]
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
#line 1 "C:\Users\237598\Desktop\ASP.NET Web Applications\TaskManagement\TaskManagement\Views\_ViewImports.cshtml"
using TaskManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\237598\Desktop\ASP.NET Web Applications\TaskManagement\TaskManagement\Views\_ViewImports.cshtml"
using TaskManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f3133d480d2ed09114af9ac43f3e3a682d08db9", @"/Views/Record/GetData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"587563bce6da232e115abd590752468cb0fe00c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Record_GetData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TaskManagement.Models.ViewModels.RecordsViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Record", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f3133d480d2ed09114af9ac43f3e3a682d08db94832", async() => {
                WriteLiteral("Create New Task");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n   <div class=\"row\" style=\"margin-top:25px\">\r\n");
#nullable restore
#line 6 "C:\Users\237598\Desktop\ASP.NET Web Applications\TaskManagement\TaskManagement\Views\Record\GetData.cshtml"
       foreach(var data in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("         <div class=\"col-sm-3 col-md-3\">\r\n            <div");
            BeginWriteAttribute("class", " class=\"", 305, "\"", 348, 5);
            WriteAttributeValue("", 313, "card", 313, 4, true);
            WriteAttributeValue(" ", 317, "text-white", 318, 11, true);
            WriteAttributeValue(" ", 328, "bg-", 329, 4, true);
#nullable restore
#line 8 "C:\Users\237598\Desktop\ASP.NET Web Applications\TaskManagement\TaskManagement\Views\Record\GetData.cshtml"
WriteAttributeValue("", 332, data.color, 332, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 343, "mb-3", 344, 5, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"max-width: 25rem;\">\r\n                <div class=\"card-header\">");
#nullable restore
#line 9 "C:\Users\237598\Desktop\ASP.NET Web Applications\TaskManagement\TaskManagement\Views\Record\GetData.cshtml"
                                    Write(data.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"card-body\">\r\n                       <h5 class=\"card-title\">");
#nullable restore
#line 11 "C:\Users\237598\Desktop\ASP.NET Web Applications\TaskManagement\TaskManagement\Views\Record\GetData.cshtml"
                                         Write(data.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                       <h6 class=\"card-title\">Date: ");
#nullable restore
#line 12 "C:\Users\237598\Desktop\ASP.NET Web Applications\TaskManagement\TaskManagement\Views\Record\GetData.cshtml"
                                               Write(data.dateTime.Substring(0,10));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <h6 class=\"card-title\">Time: ");
#nullable restore
#line 13 "C:\Users\237598\Desktop\ASP.NET Web Applications\TaskManagement\TaskManagement\Views\Record\GetData.cshtml"
                                                Write(data.dateTime.Substring(12));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <div>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f3133d480d2ed09114af9ac43f3e3a682d08db98861", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "C:\Users\237598\Desktop\ASP.NET Web Applications\TaskManagement\TaskManagement\Views\Record\GetData.cshtml"
                                                                             WriteLiteral(data.rec_id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("                            <a class=\"btn btn-danger delete\" data-id=\"");
#nullable restore
#line 17 "C:\Users\237598\Desktop\ASP.NET Web Applications\TaskManagement\TaskManagement\Views\Record\GetData.cshtml"
                                                                 Write(data.rec_id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" data-controller=""Record"" data-action=""Delete""
                                 data-body-message=""Are you sure to delete this task?"">Delete</a>
                       </div>
                         
                     </div>
                 </div>
            </div>
");
#nullable restore
#line 24 "C:\Users\237598\Desktop\ASP.NET Web Applications\TaskManagement\TaskManagement\Views\Record\GetData.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </div>\r\n     \r\n   \r\n        \r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TaskManagement.Models.ViewModels.RecordsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
