#pragma checksum "E:\IT&BSUIR\БГУИР\2 КУРС\4 сем\COURSEWORK\GForumBelarus\GForumBelarus.WebSite\Pages\Admin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f34ebe5068db2ae81140280fa63f370475cc6583"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GForumBelarus.WebSite.Pages.Pages_Admin), @"mvc.1.0.razor-page", @"/Pages/Admin.cshtml")]
namespace GForumBelarus.WebSite.Pages
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
#line 1 "E:\IT&BSUIR\БГУИР\2 КУРС\4 сем\COURSEWORK\GForumBelarus\GForumBelarus.WebSite\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\IT&BSUIR\БГУИР\2 КУРС\4 сем\COURSEWORK\GForumBelarus\GForumBelarus.WebSite\Pages\_ViewImports.cshtml"
using GForumBelarus.WebSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\IT&BSUIR\БГУИР\2 КУРС\4 сем\COURSEWORK\GForumBelarus\GForumBelarus.WebSite\Pages\_ViewImports.cshtml"
using GForumBelarus.WebSite.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\IT&BSUIR\БГУИР\2 КУРС\4 сем\COURSEWORK\GForumBelarus\GForumBelarus.WebSite\Pages\Admin.cshtml"
using GForumBelarus.WebSite.Components;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f34ebe5068db2ae81140280fa63f370475cc6583", @"/Pages/Admin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1f0d78f6f2f7da638da7703b03828ba0ec3fb27", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Admin : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "E:\IT&BSUIR\БГУИР\2 КУРС\4 сем\COURSEWORK\GForumBelarus\GForumBelarus.WebSite\Pages\Admin.cshtml"
  
    ViewData["Title"] = "Administration page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Administration Page</h1>\r\n</div>\r\n\r\n");
#nullable restore
#line 13 "E:\IT&BSUIR\БГУИР\2 КУРС\4 сем\COURSEWORK\GForumBelarus\GForumBelarus.WebSite\Pages\Admin.cshtml"
Write(await Html.RenderComponentAsync<Admin>(RenderMode.ServerPrerendered));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<script src=\"_framework/blazor.server.js\"></script> ");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GForumBelarus.WebSite.Pages.Shared.AdminModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GForumBelarus.WebSite.Pages.Shared.AdminModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GForumBelarus.WebSite.Pages.Shared.AdminModel>)PageContext?.ViewData;
        public GForumBelarus.WebSite.Pages.Shared.AdminModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591