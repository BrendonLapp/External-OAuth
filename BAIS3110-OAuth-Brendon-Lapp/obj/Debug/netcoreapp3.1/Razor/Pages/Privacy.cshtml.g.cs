#pragma checksum "C:\Users\b_lap\Documents\GitHub\BAIS3110-OAuth-Brendon-Lapp\External-OAuth\BAIS3110-OAuth-Brendon-Lapp\Pages\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7beb9d910e8f928ec9e4557285bdc37ff6bdce6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BAIS3110_OAuth_Brendon_Lapp.Pages.Pages_Privacy), @"mvc.1.0.razor-page", @"/Pages/Privacy.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7beb9d910e8f928ec9e4557285bdc37ff6bdce6a", @"/Pages/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb277cc51c62a399c003113bc9380856aeb725e3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Privacy : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 7 "C:\Users\b_lap\Documents\GitHub\BAIS3110-OAuth-Brendon-Lapp\External-OAuth\BAIS3110-OAuth-Brendon-Lapp\Pages\Privacy.cshtml"
Write(User.Claims.Where(x => x.Type == "urn:github:login").Select(c => c.Value).SingleOrDefault());

#line default
#line hidden
#nullable disable
            WriteLiteral(" is authenticated\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BAIS3110_OAuth_Brendon_Lapp.Pages.PrivacyModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BAIS3110_OAuth_Brendon_Lapp.Pages.PrivacyModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BAIS3110_OAuth_Brendon_Lapp.Pages.PrivacyModel>)PageContext?.ViewData;
        public BAIS3110_OAuth_Brendon_Lapp.Pages.PrivacyModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
