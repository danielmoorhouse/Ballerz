#pragma checksum "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Notifications/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5da5ef8162ba0a676404732a61c7456d739d19ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Notifications_Index), @"mvc.1.0.view", @"/Views/Notifications/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Notifications/Index.cshtml", typeof(AspNetCore.Views_Notifications_Index))]
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
#line 1 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/_ViewImports.cshtml"
using Ballerz;

#line default
#line hidden
#line 2 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/_ViewImports.cshtml"
using Ballerz.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5da5ef8162ba0a676404732a61c7456d739d19ee", @"/Views/Notifications/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a3225d8f68e2a14957a69ba365cd5e2a59f4c8d", @"/Views/_ViewImports.cshtml")]
    public class Views_Notifications_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Ballerz.Data.Models.Notification>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 33, true);
            WriteLiteral("\n    <div class=\"inner-wrapper\">\n");
            EndContext();
#line 4 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Notifications/Index.cshtml"
     if (Model.Any())
    {
        foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(160, 99, true);
            WriteLiteral("            <div class=\"post tight\">\n                <div class=\"post__top\">\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 259, "\"", 330, 1);
#line 10 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Notifications/Index.cshtml"
WriteAttributeValue("", 266, Url.Action("Detail", "Profile", new { @id = item.FromUser.Id }), 266, 64, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(331, 29, true);
            WriteLiteral("></a>\n                     <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 360, "\"", 430, 1);
#line 11 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Notifications/Index.cshtml"
WriteAttributeValue("", 367, Url.Action("Detail", "Profile", new { @id = item.FromUser.Id}), 367, 63, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(431, 45, true);
            WriteLiteral(" class=\"post__user\">\n                        ");
            EndContext();
            BeginContext(477, 22, false);
#line 12 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Notifications/Index.cshtml"
                   Write(item.FromUser.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(499, 70, true);
            WriteLiteral("\n                    </a>\n                  \n                    <time");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 569, "\"", 606, 1);
#line 15 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Notifications/Index.cshtml"
WriteAttributeValue("", 577, item.Timestamp.ToString("D"), 577, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(607, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(609, 34, false);
#line 15 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Notifications/Index.cshtml"
                                                           Write(item.Timestamp.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(643, 48, true);
            WriteLiteral("</time>\n\n                    <p class=\"message\">");
            EndContext();
            BeginContext(692, 12, false);
#line 17 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Notifications/Index.cshtml"
                                  Write(item.Message);

#line default
#line hidden
            EndContext();
            BeginContext(704, 47, true);
            WriteLiteral("</p>\n                </div>\n            </div>\n");
            EndContext();
#line 20 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Notifications/Index.cshtml"
        }
    }
    else
    {

#line default
#line hidden
            BeginContext(782, 36, true);
            WriteLiteral("        <p>Nothing to see here.</p>\n");
            EndContext();
#line 25 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Notifications/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(824, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Ballerz.Data.Models.Notification>> Html { get; private set; }
    }
}
#pragma warning restore 1591
