#pragma checksum "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Players/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb9bd8a1784eed0d84b93fdbc4ef9d460a690e19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Players_Details), @"mvc.1.0.view", @"/Views/Players/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Players/Details.cshtml", typeof(AspNetCore.Views_Players_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb9bd8a1784eed0d84b93fdbc4ef9d460a690e19", @"/Views/Players/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a3225d8f68e2a14957a69ba365cd5e2a59f4c8d", @"/Views/_ViewImports.cshtml")]
    public class Views_Players_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ballerz.Models.Player.PlayerDetailModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PlayerHistory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Players/Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(93, 158, true);
            WriteLiteral("\r\n<h1><strong>Ballerz | Ballerz</strong></h1>\r\n<div class=\"row\">\r\n    <div class=\"col-md-2\"></div>\r\n    <div class=\"col-md-6\">\r\n        \r\n        <h1><strong>");
            EndContext();
            BeginContext(252, 16, false);
#line 12 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Players/Details.cshtml"
               Write(Model.PlayerName);

#line default
#line hidden
            EndContext();
            BeginContext(268, 37, true);
            WriteLiteral("</strong>&nbsp;&nbsp;&nbsp;&nbsp;<img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 305, "\"", 325, 1);
#line 12 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Players/Details.cshtml"
WriteAttributeValue("", 311, Model.FlagUrl, 311, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(326, 57, true);
            WriteLiteral(" style=\"width: 75px;\" /></h1>\r\n        <h3>Born: <strong>");
            EndContext();
            BeginContext(384, 16, false);
#line 13 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Players/Details.cshtml"
                     Write(Model.BirthPlace);

#line default
#line hidden
            EndContext();
            BeginContext(400, 41, true);
            WriteLiteral("</strong></h3>\r\n        <h3>DoB: <strong>");
            EndContext();
            BeginContext(442, 29, false);
#line 14 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Players/Details.cshtml"
                    Write(Model.DoB.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(471, 60, true);
            WriteLiteral("</strong></h3>\r\n        \r\n        <h3>Current Club: <strong>");
            EndContext();
            BeginContext(532, 14, false);
#line 16 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Players/Details.cshtml"
                             Write(Model.TeamName);

#line default
#line hidden
            EndContext();
            BeginContext(546, 25, true);
            WriteLiteral("</strong>&nbsp;&nbsp;<img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 571, "\"", 596, 1);
#line 16 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Players/Details.cshtml"
WriteAttributeValue("", 577, Model.TeamBadgeUrl, 577, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(597, 61, true);
            WriteLiteral(" style=\"width: 75px;\" /></h3>\r\n        <h3>Position: <strong>");
            EndContext();
            BeginContext(659, 14, false);
#line 17 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Players/Details.cshtml"
                         Write(Model.Position);

#line default
#line hidden
            EndContext();
            BeginContext(673, 24, true);
            WriteLiteral("</strong></h3>\r\n        ");
            EndContext();
            BeginContext(697, 112, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb9bd8a1784eed0d84b93fdbc4ef9d460a690e196846", async() => {
                BeginContext(775, 5, true);
                WriteLiteral("View ");
                EndContext();
                BeginContext(781, 16, false);
#line 18 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Players/Details.cshtml"
                                                                                      Write(Model.PlayerName);

#line default
#line hidden
                EndContext();
                BeginContext(797, 8, true);
                WriteLiteral("\'s Stats");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 18 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Players/Details.cshtml"
                                                               WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(809, 62, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-4 text-center\">\r\n    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 871, "\"", 898, 1);
#line 21 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Players/Details.cshtml"
WriteAttributeValue("", 877, Model.PlayerImageUrl, 877, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(899, 74, true);
            WriteLiteral(" style=\"width: 80%; float: left;\" />\r\n    \r\n    </div>\r\n</div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ballerz.Models.Player.PlayerDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
