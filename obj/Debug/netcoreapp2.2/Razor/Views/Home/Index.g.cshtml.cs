#pragma checksum "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7fb0294a380cf6dbe708ff87da0cbe8a9009d3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7fb0294a380cf6dbe708ff87da0cbe8a9009d3c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a3225d8f68e2a14957a69ba365cd5e2a59f4c8d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ballerz.Models.Home.HomeIndexModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("homeSearch"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Search..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 267, true);
            WriteLiteral(@"
<div class=""container body-content"">
    <div class=""row frontPageSplash"">
        <div class=""col-md-6 frontPageLearn"">
            <div class=""frontPageHeading""></div>
            <p class=""frontPageSubHeading"">Ballerz</p>
            <div>
                ");
            EndContext();
            BeginContext(310, 196, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7fb0294a380cf6dbe708ff87da0cbe8a9009d3c6879", async() => {
                BeginContext(374, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(396, 85, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d7fb0294a380cf6dbe708ff87da0cbe8a9009d3c7276", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 10 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Home/Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchQuery);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(481, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(506, 1523, true);
            WriteLiteral(@"
            </div>
        </div>
        <div class=""col-md-6""></div>
    </div>
  
        <h3 style=""color: white;""><strong>Latest Posts</strong></h3>
         <div class=""col-md-10"">
                 <div class=""row"" style="" background-color: #4f4e4e; border-right: 2px solid white; padding-bottom: 10px; border-bottom: 1px solid white;"">
                        <div class=""col-md-1 text-center"">
                          
                        </div>
                        <div class=""col-md-3"" style="""">
                              
                                
                                  <h4 id=""Title1"" style=""padding-top: 15px;"">&nbsp;Post Title</h4> 
                                
                        </div>
                        <div class=""col-md-2 text-center"">
                        
                          <h4 id=""uName"" style=""padding-top: 15px;"">Post Author</h4>  
                           
                        </div>

            
          ");
            WriteLiteral(@"             <div class=""col-md-4 text-center"">
                           <h4 style=""color: white; padding-top: 15px;""> Forum </h4>
                        </div>

            
                      <div class=""col-md-2 text-center"">
                            
                                     <h4 style=""color: white; padding-top: 15px;"">Replies</p>
                                
                                   
                        </div>

                    </div>
");
            EndContext();
#line 49 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Home/Index.cshtml"
                 foreach(var post in Model.LatestPosts)
                {

#line default
#line hidden
            BeginContext(2105, 252, true);
            WriteLiteral("                    <div class=\"row\" style=\" background-color: #4f4e4e; border-right: 2px solid white; padding-bottom: 10px; border-bottom: 1px solid white;\">\r\n                        <div class=\"col-md-1 text-center\">\r\n                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2357, "\"", 2383, 1);
#line 53 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Home/Index.cshtml"
WriteAttributeValue("", 2363, post.Forum.ImageUrl, 2363, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2384, 157, true);
            WriteLiteral(" style=\"width: 100%;  padding-top: 10px;\" /> \r\n                        </div>\r\n                        <div class=\"col-md-3\">\r\n                              ");
            EndContext();
            BeginContext(2541, 242, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7fb0294a380cf6dbe708ff87da0cbe8a9009d3c13567", async() => {
                BeginContext(2609, 118, true);
                WriteLiteral("\r\n                                \r\n                                  <h5 id=\"Title\" style=\"padding-top: 10px;\">&nbsp;");
                EndContext();
                BeginContext(2728, 10, false);
#line 58 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Home/Index.cshtml"
                                                                             Write(post.Title);

#line default
#line hidden
                EndContext();
                BeginContext(2738, 41, true);
                WriteLiteral(" </h5> \r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 56 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Home/Index.cshtml"
                                                                            WriteLiteral(post.Id);

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
            BeginContext(2783, 118, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-2 text-center\">\r\n                        ");
            EndContext();
            BeginContext(2901, 220, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7fb0294a380cf6dbe708ff87da0cbe8a9009d3c16764", async() => {
                BeginContext(2979, 85, true);
                WriteLiteral("<p style=\"color: yellow;  padding: 5px;\"> \r\n                          <h5 id=\"uName\">");
                EndContext();
                BeginContext(3065, 15, false);
#line 63 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Home/Index.cshtml"
                                    Write(post.AuthorName);

#line default
#line hidden
                EndContext();
                BeginContext(3080, 37, true);
                WriteLiteral("</h5>  \r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 62 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Home/Index.cshtml"
                                                                          WriteLiteral(post.AuthorId);

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
            BeginContext(3121, 178, true);
            WriteLiteral(" \r\n                        </div>\r\n\r\n            \r\n                       <div class=\"col-md-4 text-center\">\r\n                           <p style=\"color: white; padding: 15px;\"> ");
            EndContext();
            BeginContext(3300, 15, false);
#line 69 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Home/Index.cshtml"
                                                               Write(post.Forum.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3315, 113, true);
            WriteLiteral(" </p>\r\n                        </div>\r\n\r\n            \r\n                      <div class=\"col-md-2 text-center\">\r\n");
            EndContext();
#line 74 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Home/Index.cshtml"
                               if(post.RepliesCount == 1)
                                {

#line default
#line hidden
            BeginContext(3522, 80, true);
            WriteLiteral("                                    <p style=\"color: white; padding-top: 10px;\">");
            EndContext();
            BeginContext(3603, 17, false);
#line 76 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Home/Index.cshtml"
                                                                           Write(post.RepliesCount);

#line default
#line hidden
            EndContext();
            BeginContext(3620, 12, true);
            WriteLiteral(" Reply</p>\r\n");
            EndContext();
#line 77 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Home/Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(3667, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 78 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Home/Index.cshtml"
                                 if(post.RepliesCount == 0)
                                {

#line default
#line hidden
            BeginContext(3763, 96, true);
            WriteLiteral("                                    <p style=\"color: white; padding-top: 10px;\">No Replies</p>\r\n");
            EndContext();
#line 81 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Home/Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(3967, 81, true);
            WriteLiteral("                                     <p style=\"color: white; padding-top: 10px;\">");
            EndContext();
            BeginContext(4049, 17, false);
#line 84 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Home/Index.cshtml"
                                                                            Write(post.RepliesCount);

#line default
#line hidden
            EndContext();
            BeginContext(4066, 14, true);
            WriteLiteral(" Replies</p>\r\n");
            EndContext();
#line 85 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Home/Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(4115, 99, true);
            WriteLiteral("                                   \r\n                        </div>\r\n\r\n                    </div>\r\n");
            EndContext();
#line 90 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Home/Index.cshtml"
                }

#line default
#line hidden
            BeginContext(4233, 209, true);
            WriteLiteral("                </div>\r\n                <div class=\"col-md-2\" style=\"border-left: 1px solid grey; background-color: #4f4e4e;\">\r\n                    <h4 style=\"color: white;\"><strong>New Members</strong></h4>\r\n");
            EndContext();
#line 94 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Home/Index.cshtml"
                 foreach(var user in Model.Profile)
                {

#line default
#line hidden
            BeginContext(4514, 43, true);
            WriteLiteral("                <img class=\"img img-circle\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 4557, "\"", 4584, 1);
#line 96 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Home/Index.cshtml"
WriteAttributeValue("", 4563, user.ProfileImageUrl, 4563, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4585, 50, true);
            WriteLiteral(" style=\"width: 50px; padding-right: 10px;\" /> <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 4635, "\"", 4654, 1);
#line 96 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Home/Index.cshtml"
WriteAttributeValue("", 4641, user.FlagUrl, 4641, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4655, 69, true);
            WriteLiteral(" style=\"width: 40px; padding-right: 10px;\" />\r\n                  <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 4724, "\"", 4745, 1);
#line 97 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Home/Index.cshtml"
WriteAttributeValue("", 4730, user.TeamBadge, 4730, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4746, 44, true);
            WriteLiteral(" style=\"width: 30px;\" />  \r\n                ");
            EndContext();
            BeginContext(4790, 140, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7fb0294a380cf6dbe708ff87da0cbe8a9009d3c25048", async() => {
                BeginContext(4866, 33, true);
                WriteLiteral("<p style=\"color: white;\"><strong>");
                EndContext();
                BeginContext(4900, 13, false);
#line 98 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Home/Index.cshtml"
                                                                                                                        Write(user.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(4913, 13, true);
                WriteLiteral("</strong></p>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 98 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Home/Index.cshtml"
                                                                  WriteLiteral(user.UserId);

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
            BeginContext(4930, 43, true);
            WriteLiteral("\r\n                <p style=\"color: white;\">");
            EndContext();
            BeginContext(4974, 13, false);
#line 99 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Home/Index.cshtml"
                                    Write(user.Location);

#line default
#line hidden
            EndContext();
            BeginContext(4987, 64, true);
            WriteLiteral("</p>\r\n                <p style=\"color: white; font-size: 10px;\">");
            EndContext();
            BeginContext(5052, 16, false);
#line 100 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Home/Index.cshtml"
                                                     Write(user.MemberSince);

#line default
#line hidden
            EndContext();
            BeginContext(5068, 11, true);
            WriteLiteral("</p><hr/>\r\n");
            EndContext();
#line 101 "/home/daniel/ASPProjects/Ballerz/Ballerz/Views/Home/Index.cshtml"
                }

#line default
#line hidden
            BeginContext(5098, 21, true);
            WriteLiteral("               </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ballerz.Models.Home.HomeIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591