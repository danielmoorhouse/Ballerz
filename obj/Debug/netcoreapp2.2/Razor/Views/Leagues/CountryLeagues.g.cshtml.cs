#pragma checksum "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Leagues/CountryLeagues.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcfd8eced1f1f7a0b3bf95712c7db462be9870b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Leagues_CountryLeagues), @"mvc.1.0.view", @"/Views/Leagues/CountryLeagues.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Leagues/CountryLeagues.cshtml", typeof(AspNetCore.Views_Leagues_CountryLeagues))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcfd8eced1f1f7a0b3bf95712c7db462be9870b8", @"/Views/Leagues/CountryLeagues.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a3225d8f68e2a14957a69ba365cd5e2a59f4c8d", @"/Views/_ViewImports.cshtml")]
    public class Views_Leagues_CountryLeagues : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ballerz.Models.Leagues.LeagueIndexModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Leagues", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Teams", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LeagueTeams", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-small"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(47, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(48, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fcfd8eced1f1f7a0b3bf95712c7db462be9870b84745", async() => {
                BeginContext(96, 10, true);
                WriteLiteral("Add League");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(110, 123, true);
            WriteLiteral("\n<div class=\"container-fluid\" style=\"background-color: lightgrey;\">\n<div class=\"row\" style=\" background-color: #4f4e4e; \">\n");
            EndContext();
#line 6 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Leagues/CountryLeagues.cshtml"
 foreach(var league in Model.LeagueList)
{

#line default
#line hidden
            BeginContext(276, 73, true);
            WriteLiteral("    <div class=\"col-md-3 text-center\" style=\"margin-bottom: 3em;\">\n  <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 349, "\"", 377, 1);
#line 9 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Leagues/CountryLeagues.cshtml"
WriteAttributeValue("", 355, league.LeagueImageUrl, 355, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(378, 119, true);
            WriteLiteral(" class=\"flagImg\" style=\"width: 170px; height: 160px; padding-top: 20px;\"/>\n  <h2 style=\"padding-bottom: 10px;\"><strong>");
            EndContext();
            BeginContext(498, 17, false);
#line 10 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Leagues/CountryLeagues.cshtml"
                                       Write(league.LeagueName);

#line default
#line hidden
            EndContext();
            BeginContext(515, 23, true);
            WriteLiteral("</strong></h2>\n \n  <h4>");
            EndContext();
            BeginContext(539, 18, false);
#line 12 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Leagues/CountryLeagues.cshtml"
 Write(league.CountryName);

#line default
#line hidden
            EndContext();
            BeginContext(557, 8, true);
            WriteLiteral("</h4>\n  ");
            EndContext();
            BeginContext(565, 127, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fcfd8eced1f1f7a0b3bf95712c7db462be9870b87965", async() => {
                BeginContext(665, 17, false);
#line 13 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Leagues/CountryLeagues.cshtml"
                                                                                                Write(league.LeagueName);

#line default
#line hidden
                EndContext();
                BeginContext(682, 6, true);
                WriteLiteral(" Teams");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 13 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Leagues/CountryLeagues.cshtml"
                                                       WriteLiteral(league.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(692, 16, true);
            WriteLiteral("\n  \n  \n  </div>\n");
            EndContext();
#line 17 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Leagues/CountryLeagues.cshtml"
  
}

#line default
#line hidden
            BeginContext(713, 13, true);
            WriteLiteral("</div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ballerz.Models.Leagues.LeagueIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
