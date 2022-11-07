#pragma checksum "D:\BookAppStore-master\Views\Book\BookDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4186526f2cec5665731e240770a1c25764e77869"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_BookDetail), @"mvc.1.0.view", @"/Views/Book/BookDetail.cshtml")]
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
#nullable restore
#line 1 "D:\BookAppStore-master\Views\_ViewImports.cshtml"
using BookAppStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\BookAppStore-master\Views\_ViewImports.cshtml"
using BookAppStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\BookAppStore-master\Views\_ViewImports.cshtml"
using BookAppStore.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4186526f2cec5665731e240770a1c25764e77869", @"/Views/Book/BookDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42adfba4de2ede2578215f28d3239f995a6f2805", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Book_BookDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\BookAppStore-master\Views\Book\BookDetail.cshtml"
  
    ViewData["Title"] = Model.Title;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"container\">\n    <h5 class=\"display-4\">All Book</h5>\n    <div class=\"row card-detail\">\n        <div class=\"col-6 card-detail-img\">\n            <img class=\"d-block w-100 card-detail-imge\"");
            BeginWriteAttribute("src", " src=\"", 392, "\"", 418, 1);
#nullable restore
#line 12 "D:\BookAppStore-master\Views\Book\BookDetail.cshtml"
WriteAttributeValue("", 398, Model.CoverImageUrl, 398, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 419, "\"", 445, 1);
#nullable restore
#line 12 "D:\BookAppStore-master\Views\Book\BookDetail.cshtml"
WriteAttributeValue("", 425, Model.CoverImageUrl, 425, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n        </div>\n        <div class=\"col-6\">\n            <div class=\"row\">\n                <div class=\"col-12\">\n                    <h2>");
#nullable restore
#line 17 "D:\BookAppStore-master\Views\Book\BookDetail.cshtml"
                   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n                </div>\n            </div>\n\n            <div class=\"row\">\n                <div class=\"col-12 text-primary\">\n                    <span class=\"label label-primary\">By: </span>\n                    <span class=\"monospaced\">");
#nullable restore
#line 24 "D:\BookAppStore-master\Views\Book\BookDetail.cshtml"
                                        Write(Model.ApplicationUser);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                </div>\n            </div>\n            <div class=\"row\">\n                <div class=\"col-12\">\n                    <p class=\"description\">\n                        ");
#nullable restore
#line 30 "D:\BookAppStore-master\Views\Book\BookDetail.cshtml"
                   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </p>\n                </div>\n            </div>\n            <div class=\"row\">\n                <div class=\"col-12\">\n                    <a class=\"btn btn-outline-primary\"");
            BeginWriteAttribute("href", " href=\"", 1248, "\"", 1272, 1);
#nullable restore
#line 36 "D:\BookAppStore-master\Views\Book\BookDetail.cshtml"
WriteAttributeValue("", 1255, Model.BookPdfUrl, 1255, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" target=""_blank"">
                        Read now
                    </a>
                </div>
            </div>
            <hr/>

            <ul class=""list-group"">
                <li class=""list-group-item""><span class=""font-weight-bold"">Category - </span>");
#nullable restore
#line 44 "D:\BookAppStore-master\Views\Book\BookDetail.cshtml"
                                                                                        Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                <li class=\"list-group-item\"><span class=\"font-weight-bold\">Total pages - </span>");
#nullable restore
#line 45 "D:\BookAppStore-master\Views\Book\BookDetail.cshtml"
                                                                                           Write(Model.TotalPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                <li class=\"list-group-item\"><span class=\"font-weight-bold\">Read Times - </span>5k</li>\n            </ul>\n        </div>\n    </div>\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public BookAppStore.Service.UserService _request { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Identity.SignInManager<ApplicationUser> _signInManager { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
