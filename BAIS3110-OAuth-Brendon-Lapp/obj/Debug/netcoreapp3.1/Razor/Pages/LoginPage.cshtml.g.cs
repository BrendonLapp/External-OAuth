#pragma checksum "C:\Users\b_lap\Documents\GitHub\BAIS3110-OAuth-Brendon-Lapp\External-OAuth\BAIS3110-OAuth-Brendon-Lapp\Pages\LoginPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a8ffcfabe2cd55a7bd066e6c4f5fa38db47a4b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BAIS3110_OAuth_Brendon_Lapp.Pages.Pages_LoginPage), @"mvc.1.0.razor-page", @"/Pages/LoginPage.cshtml")]
namespace BAIS3110_OAuth_Brendon_Lapp.Pages
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
#line 1 "C:\Users\b_lap\Documents\GitHub\BAIS3110-OAuth-Brendon-Lapp\External-OAuth\BAIS3110-OAuth-Brendon-Lapp\Pages\_ViewImports.cshtml"
using BAIS3110_OAuth_Brendon_Lapp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a8ffcfabe2cd55a7bd066e6c4f5fa38db47a4b7", @"/Pages/LoginPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb277cc51c62a399c003113bc9380856aeb725e3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_LoginPage : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Auth", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 3 "C:\Users\b_lap\Documents\GitHub\BAIS3110-OAuth-Brendon-Lapp\External-OAuth\BAIS3110-OAuth-Brendon-Lapp\Pages\LoginPage.cshtml"
  
    ViewData["Title"] = "Log in";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n");
#nullable restore
#line 7 "C:\Users\b_lap\Documents\GitHub\BAIS3110-OAuth-Brendon-Lapp\External-OAuth\BAIS3110-OAuth-Brendon-Lapp\Pages\LoginPage.cshtml"
     if (!User.Identity.IsAuthenticated)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a8ffcfabe2cd55a7bd066e6c4f5fa38db47a4b74552", async() => {
                WriteLiteral("Log In with GitHub");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\b_lap\Documents\GitHub\BAIS3110-OAuth-Brendon-Lapp\External-OAuth\BAIS3110-OAuth-Brendon-Lapp\Pages\LoginPage.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div id=""accordion"" class=""container-fluid"">
            <div class=""card"">
                <div class=""card-header"" id=""headingOne"">
                    <h5 class=""mb-0"">
                        <button class=""btn btn-link"" data-toggle=""collapse"" data-target=""#collapse-repos"" aria-expanded=""true"" aria-controls=""collapse-repos"">
                            Repos
                        </button>
                    </h5>
                </div>
                <div id=""collapse-repos"" class=""collapse show"" aria-labelledby=""headingOne"" data-parent=""#accordion"">
                    <div class=""card-body"">
                        <ul>
");
#nullable restore
#line 25 "C:\Users\b_lap\Documents\GitHub\BAIS3110-OAuth-Brendon-Lapp\External-OAuth\BAIS3110-OAuth-Brendon-Lapp\Pages\LoginPage.cshtml"
                             foreach (var repo in Model.Repositories)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li><a");
            BeginWriteAttribute("href", " href=\"", 1105, "\"", 1125, 1);
#nullable restore
#line 27 "C:\Users\b_lap\Documents\GitHub\BAIS3110-OAuth-Brendon-Lapp\External-OAuth\BAIS3110-OAuth-Brendon-Lapp\Pages\LoginPage.cshtml"
WriteAttributeValue("", 1112, repo.HtmlUrl, 1112, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 27 "C:\Users\b_lap\Documents\GitHub\BAIS3110-OAuth-Brendon-Lapp\External-OAuth\BAIS3110-OAuth-Brendon-Lapp\Pages\LoginPage.cshtml"
                                                       Write(repo.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 28 "C:\Users\b_lap\Documents\GitHub\BAIS3110-OAuth-Brendon-Lapp\External-OAuth\BAIS3110-OAuth-Brendon-Lapp\Pages\LoginPage.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </ul>
                    </div>
                </div>
            </div>
            <div class=""card"">
                <div class=""card-header"" id=""headingTwo"">
                    <h5 class=""mb-0"">
                        <button class=""btn btn-link collapsed"" data-toggle=""collapse"" data-target=""#collapse-starred"" aria-expanded=""false"" aria-controls=""collapse-starred"">
                            Starred Repositories
                        </button>
                    </h5>
                </div>
                <div id=""collapse-starred"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordion"">
                    <div class=""card-body"">
                        <ul>
");
#nullable restore
#line 44 "C:\Users\b_lap\Documents\GitHub\BAIS3110-OAuth-Brendon-Lapp\External-OAuth\BAIS3110-OAuth-Brendon-Lapp\Pages\LoginPage.cshtml"
                             foreach (var repo in Model.StarredRepos)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li><a");
            BeginWriteAttribute("href", " href=\"", 2058, "\"", 2078, 1);
#nullable restore
#line 46 "C:\Users\b_lap\Documents\GitHub\BAIS3110-OAuth-Brendon-Lapp\External-OAuth\BAIS3110-OAuth-Brendon-Lapp\Pages\LoginPage.cshtml"
WriteAttributeValue("", 2065, repo.HtmlUrl, 2065, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 46 "C:\Users\b_lap\Documents\GitHub\BAIS3110-OAuth-Brendon-Lapp\External-OAuth\BAIS3110-OAuth-Brendon-Lapp\Pages\LoginPage.cshtml"
                                                       Write(repo.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 47 "C:\Users\b_lap\Documents\GitHub\BAIS3110-OAuth-Brendon-Lapp\External-OAuth\BAIS3110-OAuth-Brendon-Lapp\Pages\LoginPage.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </ul>
                    </div>
                </div>
            </div>
            <div class=""card"">
                <div class=""card-header"" id=""headingThree"">
                    <h5 class=""mb-0"">
                        <button class=""btn btn-link collapsed"" data-toggle=""collapse"" data-target=""#collapse-followers"" aria-expanded=""false"" aria-controls=""collapse-followers"">
                            Followers
                        </button>
                    </h5>
                </div>
                <div id=""collapse-followers"" class=""collapse"" aria-labelledby=""headingThree"" data-parent=""#accordion"">
                    <div class=""card-body"">
                        <ul>
");
#nullable restore
#line 63 "C:\Users\b_lap\Documents\GitHub\BAIS3110-OAuth-Brendon-Lapp\External-OAuth\BAIS3110-OAuth-Brendon-Lapp\Pages\LoginPage.cshtml"
                             foreach (var follower in Model.Followers)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li><a");
            BeginWriteAttribute("href", " href=\"", 3011, "\"", 3035, 1);
#nullable restore
#line 65 "C:\Users\b_lap\Documents\GitHub\BAIS3110-OAuth-Brendon-Lapp\External-OAuth\BAIS3110-OAuth-Brendon-Lapp\Pages\LoginPage.cshtml"
WriteAttributeValue("", 3018, follower.HtmlUrl, 3018, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 65 "C:\Users\b_lap\Documents\GitHub\BAIS3110-OAuth-Brendon-Lapp\External-OAuth\BAIS3110-OAuth-Brendon-Lapp\Pages\LoginPage.cshtml"
                                                           Write(follower.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 66 "C:\Users\b_lap\Documents\GitHub\BAIS3110-OAuth-Brendon-Lapp\External-OAuth\BAIS3110-OAuth-Brendon-Lapp\Pages\LoginPage.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </ul>
                    </div>
                </div>
            </div>
            <div class=""card"">
                <div class=""card-header"" id=""headingFour"">
                    <h5 class=""mb-0"">
                        <button class=""btn btn-link collapsed"" data-toggle=""collapse"" data-target=""#collapse-following"" aria-expanded=""false"" aria-controls=""collapse-following"">
                            Following
                        </button>
                    </h5>
                </div>
                <div id=""collapse-following"" class=""collapse"" aria-labelledby=""headingFour"" data-parent=""#accordion"">
                    <div class=""card-body"">
                        <ul>
");
#nullable restore
#line 82 "C:\Users\b_lap\Documents\GitHub\BAIS3110-OAuth-Brendon-Lapp\External-OAuth\BAIS3110-OAuth-Brendon-Lapp\Pages\LoginPage.cshtml"
                             foreach (var follower in Model.Followers)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li><a");
            BeginWriteAttribute("href", " href=\"", 3967, "\"", 3991, 1);
#nullable restore
#line 84 "C:\Users\b_lap\Documents\GitHub\BAIS3110-OAuth-Brendon-Lapp\External-OAuth\BAIS3110-OAuth-Brendon-Lapp\Pages\LoginPage.cshtml"
WriteAttributeValue("", 3974, follower.HtmlUrl, 3974, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 84 "C:\Users\b_lap\Documents\GitHub\BAIS3110-OAuth-Brendon-Lapp\External-OAuth\BAIS3110-OAuth-Brendon-Lapp\Pages\LoginPage.cshtml"
                                                           Write(follower.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 85 "C:\Users\b_lap\Documents\GitHub\BAIS3110-OAuth-Brendon-Lapp\External-OAuth\BAIS3110-OAuth-Brendon-Lapp\Pages\LoginPage.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 91 "C:\Users\b_lap\Documents\GitHub\BAIS3110-OAuth-Brendon-Lapp\External-OAuth\BAIS3110-OAuth-Brendon-Lapp\Pages\LoginPage.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BAIS3110_OAuth_Brendon_Lapp.Pages.LoginPageModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BAIS3110_OAuth_Brendon_Lapp.Pages.LoginPageModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BAIS3110_OAuth_Brendon_Lapp.Pages.LoginPageModel>)PageContext?.ViewData;
        public BAIS3110_OAuth_Brendon_Lapp.Pages.LoginPageModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
