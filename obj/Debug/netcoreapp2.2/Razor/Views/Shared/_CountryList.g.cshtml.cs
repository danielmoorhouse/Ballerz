#pragma checksum "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Shared/_CountryList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b6f90906598e2345f9f22f86cbce9823fb6f91f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CountryList), @"mvc.1.0.view", @"/Views/Shared/_CountryList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_CountryList.cshtml", typeof(AspNetCore.Views_Shared__CountryList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b6f90906598e2345f9f22f86cbce9823fb6f91f", @"/Views/Shared/_CountryList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a3225d8f68e2a14957a69ba365cd5e2a59f4c8d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__CountryList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ballerz.Models.Countries.CountriesListingModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(56, 10, false);
#line 3 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Shared/_CountryList.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(66, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(68, 13, false);
#line 4 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Shared/_CountryList.cshtml"
Write(Model.FlagUrl);

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ballerz.Models.Countries.CountriesListingModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
