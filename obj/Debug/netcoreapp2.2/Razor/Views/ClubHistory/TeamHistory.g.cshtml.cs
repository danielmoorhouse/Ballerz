#pragma checksum "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/ClubHistory/TeamHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b231ac5282339d40f3ff62ddcaa0612fdc168c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ClubHistory_TeamHistory), @"mvc.1.0.view", @"/Views/ClubHistory/TeamHistory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ClubHistory/TeamHistory.cshtml", typeof(AspNetCore.Views_ClubHistory_TeamHistory))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b231ac5282339d40f3ff62ddcaa0612fdc168c9", @"/Views/ClubHistory/TeamHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a3225d8f68e2a14957a69ba365cd5e2a59f4c8d", @"/Views/_ViewImports.cshtml")]
    public class Views_ClubHistory_TeamHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ballerz.Models.ClubHistory.ClubHistoryIndexModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 28, true);
            WriteLiteral("\n\n    <div class=\"row\">\n<h1>");
            EndContext();
            BeginContext(85, 16, false);
#line 5 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/ClubHistory/TeamHistory.cshtml"
Write(ViewBag.TeamName);

#line default
#line hidden
            EndContext();
            BeginContext(101, 352, true);
            WriteLiteral(@"</h1>
        <hr/>
        <div class=""col-md-2"">
            <h5><strong>Season</strong></h5>

 </div>
 <div class=""col-md-3"">
     <h5><strong>League</strong></h5>

 </div>
 <div class=""col-md-2"">
     <h5><strong>League Position</strong></h5>
 
 </div>
 <div class=""col-md-2"">
     <h5><strong>Points</strong> </h5>
     
 
 </div>
    </div>
    
");
            EndContext();
#line 26 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/ClubHistory/TeamHistory.cshtml"
 foreach(var item in Model.HistoryList)
{

#line default
#line hidden
            BeginContext(495, 118, true);
            WriteLiteral("    <div class=\"row\" style=\"margin-bottom: 7px;\">\n        <div class=\"col-md-2\">\n            <p style=\"color: white;\">");
            EndContext();
            BeginContext(614, 11, false);
#line 30 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/ClubHistory/TeamHistory.cshtml"
                                Write(item.Season);

#line default
#line hidden
            EndContext();
            BeginContext(625, 68, true);
            WriteLiteral("</p>\n \n </div>\n <div class=\"col-md-3\">\n    <p style=\"color: white;\">");
            EndContext();
            BeginContext(694, 15, false);
#line 34 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/ClubHistory/TeamHistory.cshtml"
                        Write(item.LeagueName);

#line default
#line hidden
            EndContext();
            BeginContext(709, 69, true);
            WriteLiteral("</p>\n \n </div>\n <div class=\"col-md-2\">\n     <p style=\"color: white;\">");
            EndContext();
            BeginContext(779, 13, false);
#line 38 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/ClubHistory/TeamHistory.cshtml"
                         Write(item.Position);

#line default
#line hidden
            EndContext();
            BeginContext(792, 69, true);
            WriteLiteral("</p>\n \n </div>\n <div class=\"col-md-2\">\n     <p style=\"color: white;\">");
            EndContext();
            BeginContext(862, 11, false);
#line 42 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/ClubHistory/TeamHistory.cshtml"
                         Write(item.Points);

#line default
#line hidden
            EndContext();
            BeginContext(873, 26, true);
            WriteLiteral("</p>\n \n </div>\n    </div>\n");
            EndContext();
#line 46 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/ClubHistory/TeamHistory.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ballerz.Models.ClubHistory.ClubHistoryIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
