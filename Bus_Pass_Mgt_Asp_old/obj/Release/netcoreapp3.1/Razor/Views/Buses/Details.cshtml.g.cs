#pragma checksum "C:\Users\Rishi\source\repos\Bus_Pass_Mgt_Asp\Bus_Pass_Mgt_Asp\Views\Buses\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04f16a5f65e83f01c9eadea7481888c5f556a6f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Buses_Details), @"mvc.1.0.view", @"/Views/Buses/Details.cshtml")]
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
#line 1 "C:\Users\Rishi\source\repos\Bus_Pass_Mgt_Asp\Bus_Pass_Mgt_Asp\Views\_ViewImports.cshtml"
using Bus_Pass_Mgt_Asp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rishi\source\repos\Bus_Pass_Mgt_Asp\Bus_Pass_Mgt_Asp\Views\_ViewImports.cshtml"
using Bus_Pass_Mgt_Asp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04f16a5f65e83f01c9eadea7481888c5f556a6f1", @"/Views/Buses/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae916137e93ed4efa8668ab5346b51a01c444dd6", @"/Views/_ViewImports.cshtml")]
    public class Views_Buses_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bus_Pass_Mgt_Asp.Models.Bus>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Rishi\source\repos\Bus_Pass_Mgt_Asp\Bus_Pass_Mgt_Asp\Views\Buses\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container d-xl-flex align-items-xl-end"" style=""margin-top: 20px;"">
    <h4 class=""text-danger flex-fill"">Details</h4>
</div>
<hr />
<div class=""container"" style=""margin-top: 16px;"">

    <h4>Bus</h4>
    <hr />
    <dl class=""row"">
        <dt class=""col-sm-2"">
            ");
#nullable restore
#line 17 "C:\Users\Rishi\source\repos\Bus_Pass_Mgt_Asp\Bus_Pass_Mgt_Asp\Views\Buses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BusNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Rishi\source\repos\Bus_Pass_Mgt_Asp\Bus_Pass_Mgt_Asp\Views\Buses\Details.cshtml"
       Write(Html.DisplayFor(model => model.BusNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Rishi\source\repos\Bus_Pass_Mgt_Asp\Bus_Pass_Mgt_Asp\Views\Buses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VisitingAreas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 26 "C:\Users\Rishi\source\repos\Bus_Pass_Mgt_Asp\Bus_Pass_Mgt_Asp\Views\Buses\Details.cshtml"
       Write(Html.DisplayFor(model => model.VisitingAreas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bus_Pass_Mgt_Asp.Models.Bus> Html { get; private set; }
    }
}
#pragma warning restore 1591
