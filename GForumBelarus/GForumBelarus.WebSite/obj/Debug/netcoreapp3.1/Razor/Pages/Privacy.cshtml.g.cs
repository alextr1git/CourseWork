#pragma checksum "E:\IT&BSUIR\БГУИР\2 КУРС\4 сем\COURSEWORK\CourseWork\GForumBelarus\GForumBelarus.WebSite\Pages\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ef7df3dc0d585414e1724d3c86330ab3c3b0a37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GForumBelarus.WebSite.Pages.Pages_Privacy), @"mvc.1.0.razor-page", @"/Pages/Privacy.cshtml")]
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
#line 1 "E:\IT&BSUIR\БГУИР\2 КУРС\4 сем\COURSEWORK\CourseWork\GForumBelarus\GForumBelarus.WebSite\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\IT&BSUIR\БГУИР\2 КУРС\4 сем\COURSEWORK\CourseWork\GForumBelarus\GForumBelarus.WebSite\Pages\_ViewImports.cshtml"
using GForumBelarus.WebSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\IT&BSUIR\БГУИР\2 КУРС\4 сем\COURSEWORK\CourseWork\GForumBelarus\GForumBelarus.WebSite\Pages\_ViewImports.cshtml"
using GForumBelarus.WebSite.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\IT&BSUIR\БГУИР\2 КУРС\4 сем\COURSEWORK\CourseWork\GForumBelarus\GForumBelarus.WebSite\Pages\Privacy.cshtml"
using GForumBelarus.WebSite.Components;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ef7df3dc0d585414e1724d3c86330ab3c3b0a37", @"/Pages/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fdfda9331d14884d580a0e3fad13c8e045c6ae9", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Privacy : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "E:\IT&BSUIR\БГУИР\2 КУРС\4 сем\COURSEWORK\CourseWork\GForumBelarus\GForumBelarus.WebSite\Pages\Privacy.cshtml"
  
    ViewData["Title"] = "Privacy Policy";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\n    <h1 class=\"display-4\">Поделитесь своим любимым местом</h1>\n    <p>Заполните поля ниже и нажмите \"Опубликовать\"</p>\n    <p></p>\n    <br>\n    <br>\n</div>\n");
#nullable restore
#line 14 "E:\IT&BSUIR\БГУИР\2 КУРС\4 сем\COURSEWORK\CourseWork\GForumBelarus\GForumBelarus.WebSite\Pages\Privacy.cshtml"
Write(await Html.RenderComponentAsync<Component>(RenderMode.ServerPrerendered));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    <script src=\"_framework/blazor.server.js\"></script> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PrivacyModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PrivacyModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PrivacyModel>)PageContext?.ViewData;
        public PrivacyModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
