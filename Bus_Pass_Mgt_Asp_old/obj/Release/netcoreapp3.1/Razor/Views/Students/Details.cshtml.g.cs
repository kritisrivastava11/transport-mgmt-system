#pragma checksum "C:\Users\Rishi\source\repos\Bus_Pass_Mgt_Asp\Bus_Pass_Mgt_Asp\Views\Students\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51b497da4546f0aa3b2da7092bd928f09f344151"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Details), @"mvc.1.0.view", @"/Views/Students/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51b497da4546f0aa3b2da7092bd928f09f344151", @"/Views/Students/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae916137e93ed4efa8668ab5346b51a01c444dd6", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bus_Pass_Mgt_Asp.Models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Rishi\source\repos\Bus_Pass_Mgt_Asp\Bus_Pass_Mgt_Asp\Views\Students\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container d-xl-flex align-items-xl-end"" style=""margin-top: 20px;"">
    <h4 class=""text-danger flex-fill"">Details</h4>
</div>
<hr />
<div class=""container"" style=""margin-top: 16px;"">


    <h4>Student</h4>
    <hr />
    <dl class=""row"">
        <dt class=""col-sm-2"">
            ");
#nullable restore
#line 17 "C:\Users\Rishi\source\repos\Bus_Pass_Mgt_Asp\Bus_Pass_Mgt_Asp\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StudentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Rishi\source\repos\Bus_Pass_Mgt_Asp\Bus_Pass_Mgt_Asp\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.StudentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Rishi\source\repos\Bus_Pass_Mgt_Asp\Bus_Pass_Mgt_Asp\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 26 "C:\Users\Rishi\source\repos\Bus_Pass_Mgt_Asp\Bus_Pass_Mgt_Asp\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Rishi\source\repos\Bus_Pass_Mgt_Asp\Bus_Pass_Mgt_Asp\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Mobile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Rishi\source\repos\Bus_Pass_Mgt_Asp\Bus_Pass_Mgt_Asp\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.Mobile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Rishi\source\repos\Bus_Pass_Mgt_Asp\Bus_Pass_Mgt_Asp\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 38 "C:\Users\Rishi\source\repos\Bus_Pass_Mgt_Asp\Bus_Pass_Mgt_Asp\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bus_Pass_Mgt_Asp.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
