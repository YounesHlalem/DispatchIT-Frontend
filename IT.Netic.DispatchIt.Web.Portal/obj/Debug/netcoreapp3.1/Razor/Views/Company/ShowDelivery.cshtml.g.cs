#pragma checksum "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Company\ShowDelivery.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3202fe3f48057b5c730cab2417e414fea373382"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Company_ShowDelivery), @"mvc.1.0.view", @"/Views/Company/ShowDelivery.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3202fe3f48057b5c730cab2417e414fea373382", @"/Views/Company/ShowDelivery.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"240b320ab2a118e545090773ceb49e7aa635f579", @"/Views/_ViewImports.cshtml")]
    public class Views_Company_ShowDelivery : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IT.Netic.DispatchIt.Web.Backend.DataContracts.BaseDto.DeliveryrequestBaseDto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Company\ShowDelivery.cshtml"
  
    ViewData["Title"] = "Deliveryrequest";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("HeaderScripts", async() => {
                WriteLiteral(@"
    <script src=""https://polyfill.io/v3/polyfill.min.js?features=default""></script>
    <style type=""text/css"">
        #map {
            height: 500px;
        }
    </style>
    <script>
        function initMap() {
            const myLatLng = { lat: ");
#nullable restore
#line 16 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Company\ShowDelivery.cshtml"
                               Write(Model.progress.latitude);

#line default
#line hidden
#nullable disable
                WriteLiteral(", lng: ");
#nullable restore
#line 16 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Company\ShowDelivery.cshtml"
                                                              Write(Model.progress.longitude);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" };
            const map = new google.maps.Map(document.getElementById(""map""), {
                zoom: 8,
                center: myLatLng,
            });
            new google.maps.Marker({
                position: myLatLng,
                map,
                title: ""Package Location"",
            });
        }
    </script>
");
            }
            );
            WriteLiteral("\r\n");
#nullable restore
#line 30 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Company\ShowDelivery.cshtml"
 if (Model == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2 class=\"display-4\" style=\"padding-top: 40px\">No item was found!</h2>\r\n");
#nullable restore
#line 33 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Company\ShowDelivery.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <h1 class=""display-4"" style=""padding-top: 40px"">Delivery request:</h1>
    <table class=""table"" style=""padding-top: 30px"">
        <tr>
            <th>
                Created on:
            </th>
            <th>
                Status
            </th>
            <th>
                Title
            </th>
            <th>
                Description
            </th>
            <th>
                Packet dimensions
            </th>
            <th>
                Additional instructions
            </th>

");
#nullable restore
#line 58 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Company\ShowDelivery.cshtml"
             if (Model.status == "Open" || Model.status == "Pending")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <th>\r\n                    Expected pickup-time\r\n                </th>\r\n                <th>\r\n                    Expected delivery-time\r\n                </th>\r\n");
#nullable restore
#line 66 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Company\ShowDelivery.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <th>\r\n                    Actual pickup-time\r\n                </th>\r\n                <th>\r\n                    Actual delivery-time\r\n                </th>\r\n");
#nullable restore
#line 75 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Company\ShowDelivery.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <th>\r\n                Delivery Address\r\n            </th>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 82 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Company\ShowDelivery.cshtml"
           Write(Html.DisplayFor(modelItem => Model.creationDatetime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 85 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Company\ShowDelivery.cshtml"
           Write(Html.DisplayFor(modelItem => Model.status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 88 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Company\ShowDelivery.cshtml"
           Write(Html.DisplayFor(modelItem => Model.title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 91 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Company\ShowDelivery.cshtml"
           Write(Html.DisplayFor(modelItem => Model.description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 94 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Company\ShowDelivery.cshtml"
           Write(Html.DisplayFor(modelItem => Model.packetDimensions));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 97 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Company\ShowDelivery.cshtml"
           Write(Html.DisplayFor(modelItem => Model.additionalInstructions));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n");
#nullable restore
#line 100 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Company\ShowDelivery.cshtml"
             if (Model.status == "Open" || Model.status == "Pending")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 103 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Company\ShowDelivery.cshtml"
               Write(Html.DisplayFor(modelItem => Model.expectedpickup));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 106 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Company\ShowDelivery.cshtml"
               Write(Html.DisplayFor(modelItem => Model.expecteddelivery));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
#nullable restore
#line 108 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Company\ShowDelivery.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 112 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Company\ShowDelivery.cshtml"
               Write(Html.DisplayFor(modelItem => Model.progress.actualPickupTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 115 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Company\ShowDelivery.cshtml"
               Write(Html.DisplayFor(modelItem => Model.progress.actualDeliveryTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
#nullable restore
#line 117 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Company\ShowDelivery.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <td>\r\n                <p>\r\n                    ");
#nullable restore
#line 121 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Company\ShowDelivery.cshtml"
               Write(Html.DisplayFor(modelItem => Model.deliveryAddress.Zipcode));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 121 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Company\ShowDelivery.cshtml"
                                                                            Write(Html.DisplayFor(modelItem => Model.deliveryAddress.City));

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 121 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Company\ShowDelivery.cshtml"
                                                                                                                                       Write(Html.DisplayFor(modelItem => Model.deliveryAddress.Streetname));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 121 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Company\ShowDelivery.cshtml"
                                                                                                                                                                                                       Write(Html.DisplayFor(modelItem => Model.deliveryAddress.Number));

#line default
#line hidden
#nullable disable
#nullable restore
#line 121 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Company\ShowDelivery.cshtml"
                                                                                                                                                                                                                                                                  Write(Html.DisplayFor(modelItem => Model.deliveryAddress.Addition));

#line default
#line hidden
#nullable disable
            WriteLiteral(" in ");
#nullable restore
#line 121 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Company\ShowDelivery.cshtml"
                                                                                                                                                                                                                                                                                                                                   Write(Html.DisplayFor(modelItem => Model.deliveryAddress.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n            <td>\r\n        </tr>\r\n    </table>\r\n");
            WriteLiteral("    <div id=\"map\"></div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n        <script src=\"https://maps.googleapis.com/maps/api/js?key=AIzaSyBjOpxcEW0fbvLSO6b5yDqCtRf7lJRAlts&callback=initMap&libraries=&v=weekly\" async></script>\r\n    ");
            }
            );
#nullable restore
#line 132 "C:\Users\Younes\Downloads\DispatchIT\IT.Netic.DispatchIt.Web\IT.Netic.DispatchIt.Web.Portal\Views\Company\ShowDelivery.cshtml"
     
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IT.Netic.DispatchIt.Web.Backend.DataContracts.BaseDto.DeliveryrequestBaseDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
