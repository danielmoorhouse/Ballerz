#pragma checksum "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Teams/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "095ce3df43f1a12e40e8aa0fa2b86b6efe8c8b28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teams_Index), @"mvc.1.0.view", @"/Views/Teams/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Teams/Index.cshtml", typeof(AspNetCore.Views_Teams_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"095ce3df43f1a12e40e8aa0fa2b86b6efe8c8b28", @"/Views/Teams/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a3225d8f68e2a14957a69ba365cd5e2a59f4c8d", @"/Views/_ViewImports.cshtml")]
    public class Views_Teams_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ballerz.Models.Teams.TeamIndexModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 20, true);
            WriteLiteral("\n\n<div class=\"row\">\n");
            EndContext();
#line 5 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Teams/Index.cshtml"
 foreach(var team in Model.TeamList)
{

#line default
#line hidden
            BeginContext(102, 127, true);
            WriteLiteral("    <div class=\"col-md-3 text-center\" style=\"margin-bottom: 10px; \">\n        <div style=\"width: 100%; height: 190px;\">\n    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 229, "\"", 253, 1);
#line 9 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Teams/Index.cshtml"
WriteAttributeValue("", 235, team.TeamBadgeUrl, 235, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(254, 65, true);
            WriteLiteral(" style=\"width: 150px; bottom: 0;\" />\n </div>\n <br/>\n <h5><strong>");
            EndContext();
            BeginContext(320, 13, false);
#line 12 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Teams/Index.cshtml"
        Write(team.TeamName);

#line default
#line hidden
            EndContext();
            BeginContext(333, 22, true);
            WriteLiteral("</strong></h5>\n \n <h4>");
            EndContext();
            BeginContext(356, 13, false);
#line 14 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Teams/Index.cshtml"
Write(team.Nickname);

#line default
#line hidden
            EndContext();
            BeginContext(369, 23, true);
            WriteLiteral("</h4>\n \n <h5>Founded:  ");
            EndContext();
            BeginContext(393, 16, false);
#line 16 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Teams/Index.cshtml"
          Write(team.YearFounded);

#line default
#line hidden
            EndContext();
            BeginContext(409, 17, true);
            WriteLiteral("</h5>\n \n\n </div>\n");
            EndContext();
#line 20 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Teams/Index.cshtml"
}

#line default
#line hidden
            BeginContext(428, 6, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ballerz.Models.Teams.TeamIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
