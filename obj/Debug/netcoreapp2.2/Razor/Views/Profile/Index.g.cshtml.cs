#pragma checksum "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Profile/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bb228c7249d71854db91186555d8172dd4a4e30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Index), @"mvc.1.0.view", @"/Views/Profile/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Profile/Index.cshtml", typeof(AspNetCore.Views_Profile_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bb228c7249d71854db91186555d8172dd4a4e30", @"/Views/Profile/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a3225d8f68e2a14957a69ba365cd5e2a59f4c8d", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ballerz.Models.Profile.ProfileListModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 555, true);
            WriteLiteral(@"
<div class=""container body-content"">
    <div class=""row sectionHeader"">
        <div class=""sectionHeading"">Browser Users</div>
    </div>
    <div class=""row"" id=""forumIndexContent"">
        <table class=""table table-hover"" id=""userIndexTable"">
            <thead>
                <tr>
                    <th>Image</th>
                    <th>Username</th>
                    <th>Email</th>
                    <th>Member Since</th>
                    <th>Rating</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 19 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Profile/Index.cshtml"
                 foreach(var profile in Model.Profiles){

#line default
#line hidden
            BeginContext(661, 127, true);
            WriteLiteral("                    <tr class=\"userRow\">\r\n                        <td>\r\n                            <div class=\"userProfilePic\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 788, "\"", 843, 4);
            WriteAttributeValue("", 796, "background-image:", 796, 17, true);
            WriteAttributeValue(" ", 813, "url(", 814, 5, true);
#line 22 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Profile/Index.cshtml"
WriteAttributeValue("", 818, profile.ProfileImageUrl, 818, 24, false);

#line default
#line hidden
            WriteAttributeValue("", 842, ")", 842, 1, true);
            EndWriteAttribute();
            BeginContext(844, 98, true);
            WriteLiteral("></div>\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(943, 17, false);
#line 25 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Profile/Index.cshtml"
                       Write(profile.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(960, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1052, 16, false);
#line 28 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Profile/Index.cshtml"
                       Write(profile.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1068, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1160, 23, false);
#line 31 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Profile/Index.cshtml"
                       Write(profile.ProfileImageUrl);

#line default
#line hidden
            EndContext();
            BeginContext(1183, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1275, 18, false);
#line 34 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Profile/Index.cshtml"
                       Write(profile.UserRating);

#line default
#line hidden
            EndContext();
            BeginContext(1293, 93, true);
            WriteLiteral("\r\n                        </td>\r\n                          <td>\r\n                            ");
            EndContext();
            BeginContext(1387, 19, false);
#line 37 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Profile/Index.cshtml"
                       Write(profile.MemberSince);

#line default
#line hidden
            EndContext();
            BeginContext(1406, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 40 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Profile/Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1485, 58, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ballerz.Models.Profile.ProfileListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
