#pragma checksum "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "674aded9e1a633f0cedee8d4394886de9afd437c"
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
#line 1 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\_ViewImports.cshtml"
using IT.Netic.DispatchIt.Web.Portal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\_ViewImports.cshtml"
using IT.Netic.DispatchIt.Web.Portal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"674aded9e1a633f0cedee8d4394886de9afd437c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"240b320ab2a118e545090773ceb49e7aa635f579", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IT.Netic.DispatchIt.Web.Backend.DataContracts.BaseDto.DeliveryrequestBaseDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-brand"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Company", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CompanyIndex", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Home\Index.cshtml"
 if (Model == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""d-flex justify-content-center align-items-center"" style=""height:450px;"">
        <div class=""text-center"">
            <h1 class=""display-4"">Welcome to DispatchIT</h1>
            <h3>You have no active deliveries.</h3>
            <br />
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "674aded9e1a633f0cedee8d4394886de9afd437c5325", async() => {
                WriteLiteral("Go to my companies to add >");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 16 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Home\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <h1 class=""display-4"" style=""padding-top: 40px"">Delivery requests:</h1>
    <table class=""table"" style=""padding-top: 30px"">
        <thead>
            <tr>
                <th scope=""col"">Status</th>
                <th scope=""col"">Company</th>
                <th scope=""col"">Delivery title</th>
                <th scope=""col"">Description</th>
                <th scope=""col"">Packet dimensions</th>
                <th scope=""col"">Creation date</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 32 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Home\Index.cshtml"
                 if (item.status == "Open")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 37 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.status));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>Integration.team</td>\r\n                        <td>");
#nullable restore
#line 39 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 40 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 41 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.packetDimensions));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 42 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.creationDatetime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 44 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Home\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Home\Index.cshtml"
                 if (item.status != "Open")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 51 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.status));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>Integration.team</td>\r\n                        <td>");
#nullable restore
#line 53 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 54 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 55 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.packetDimensions));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 56 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.creationDatetime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 58 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Home\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 62 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Home\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IT.Netic.DispatchIt.Web.Backend.DataContracts.BaseDto.DeliveryrequestBaseDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
