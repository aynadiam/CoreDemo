#pragma checksum "C:\Users\Aydın\YandexDisk\web\CoreKamp\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db2374eb4bd4855067773f4c68f95b9494040b4c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogListByWriter), @"mvc.1.0.view", @"/Views/Blog/BlogListByWriter.cshtml")]
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
#line 1 "C:\Users\Aydın\YandexDisk\web\CoreKamp\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Aydın\YandexDisk\web\CoreKamp\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Aydın\YandexDisk\web\CoreKamp\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db2374eb4bd4855067773f4c68f95b9494040b4c", @"/Views/Blog/BlogListByWriter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ca0fc599d5f51e519f75ff6712b592ffabce4a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_BlogListByWriter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Aydın\YandexDisk\web\CoreKamp\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
  
    ViewData["Title"] = "Yazarın Blogları";
    Layout = "~/Views/Shared/_WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"content-wrapper\">\r\n    <div class=\"page-header\">\r\n        <h3 class=\"page-title\"> ");
#nullable restore
#line 11 "C:\Users\Aydın\YandexDisk\web\CoreKamp\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
                           Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n        <nav aria-label=\"breadcrumb\">\r\n            <ol class=\"breadcrumb\">\r\n                <li class=\"breadcrumb-item\"><a href=\"#\">Anasayfa</a></li>\r\n                <li class=\"breadcrumb-item active\" aria-current=\"page\">");
#nullable restore
#line 15 "C:\Users\Aydın\YandexDisk\web\CoreKamp\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
                                                                  Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
            </ol>
        </nav>
    </div>
    <div class=""row"">
        <div class=""col-lg-12 grid-margin stretch-card"">
            <div class=""card"">
                <div class=""card-body"">
                    <p class=""card-description"">
                        <a href=""/Blog/BlogAdd"" class=""btn btn-primary btn-sm"">Yeni Blog Oluştur</a>
                    </p>
                    <table class=""table table-bordered"">
                        <thead>
                            <tr>
                                <th> # </th>
                                <th> Blog Başlığı </th>
                                <th> Oluşturma Tarihi </th>
                                <th> Kategori </th>
                                <th> Durum </th>
                                <th> Sil </th>
                                <th> Düzenle </th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 39 "C:\Users\Aydın\YandexDisk\web\CoreKamp\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td> ");
#nullable restore
#line 42 "C:\Users\Aydın\YandexDisk\web\CoreKamp\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
                                    Write(item.BlogId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td> ");
#nullable restore
#line 43 "C:\Users\Aydın\YandexDisk\web\CoreKamp\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
                                    Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td> ");
#nullable restore
#line 44 "C:\Users\Aydın\YandexDisk\web\CoreKamp\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
                                    Write(item.BlogCreateDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td> ");
#nullable restore
#line 45 "C:\Users\Aydın\YandexDisk\web\CoreKamp\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
                                    Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td> ");
#nullable restore
#line 46 "C:\Users\Aydın\YandexDisk\web\CoreKamp\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
                                    Write(Html.Raw(item.BlogStatus ? "<label class='badge badge-success'>Aktif</label>" : "<label class='badge badge-danger'>Pasif</label>"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td> <a");
            BeginWriteAttribute("href", " href=\"", 2110, "\"", 2146, 2);
            WriteAttributeValue("", 2117, "/Blog/DeleteBlog/", 2117, 17, true);
#nullable restore
#line 47 "C:\Users\Aydın\YandexDisk\web\CoreKamp\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
WriteAttributeValue("", 2134, item.BlogId, 2134, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-sm\" onclick=\"return confirm(\'Simek İstediğine Emin misin?\')\">Sil</a> </td>\r\n                                    <td> <a");
            BeginWriteAttribute("href", " href=\"", 2293, "\"", 2327, 2);
            WriteAttributeValue("", 2300, "/Blog/EditBlog/", 2300, 15, true);
#nullable restore
#line 48 "C:\Users\Aydın\YandexDisk\web\CoreKamp\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
WriteAttributeValue("", 2315, item.BlogId, 2315, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning btn-sm\">Düzenle</a> </td>\r\n                                </tr>\r\n");
#nullable restore
#line 50 "C:\Users\Aydın\YandexDisk\web\CoreKamp\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591