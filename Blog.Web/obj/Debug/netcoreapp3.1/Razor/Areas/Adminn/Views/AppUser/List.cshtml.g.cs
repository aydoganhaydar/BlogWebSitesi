#pragma checksum "C:\Users\AYDOĞANLAR\Desktop\YAZILIM KURS DERS NOTLARIM\PROJE\Blog\Blog.Web\Areas\Adminn\Views\AppUser\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b0f863e92eccc9fb9f59f1791e47ce10407cdfd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Adminn_Views_AppUser_List), @"mvc.1.0.view", @"/Areas/Adminn/Views/AppUser/List.cshtml")]
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
#line 1 "C:\Users\AYDOĞANLAR\Desktop\YAZILIM KURS DERS NOTLARIM\PROJE\Blog\Blog.Web\Areas\Adminn\Views\_ViewImports.cshtml"
using Blog.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AYDOĞANLAR\Desktop\YAZILIM KURS DERS NOTLARIM\PROJE\Blog\Blog.Web\Areas\Adminn\Views\_ViewImports.cshtml"
using Blog.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AYDOĞANLAR\Desktop\YAZILIM KURS DERS NOTLARIM\PROJE\Blog\Blog.Web\Areas\Adminn\Views\_ViewImports.cshtml"
using Blog.Web.Models.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AYDOĞANLAR\Desktop\YAZILIM KURS DERS NOTLARIM\PROJE\Blog\Blog.Web\Areas\Adminn\Views\_ViewImports.cshtml"
using Blog.Model.Entities.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\AYDOĞANLAR\Desktop\YAZILIM KURS DERS NOTLARIM\PROJE\Blog\Blog.Web\Areas\Adminn\Views\_ViewImports.cshtml"
using Blog.Web.Areas.Member.Models.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\AYDOĞANLAR\Desktop\YAZILIM KURS DERS NOTLARIM\PROJE\Blog\Blog.Web\Areas\Adminn\Views\_ViewImports.cshtml"
using Blog.Web.Areas.Adminn.Models.VMs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\AYDOĞANLAR\Desktop\YAZILIM KURS DERS NOTLARIM\PROJE\Blog\Blog.Web\Areas\Adminn\Views\_ViewImports.cshtml"
using Blog.Web.Areas.Adminn.Models.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\AYDOĞANLAR\Desktop\YAZILIM KURS DERS NOTLARIM\PROJE\Blog\Blog.Web\Areas\Adminn\Views\_ViewImports.cshtml"
using Blog.Model.Entities.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\AYDOĞANLAR\Desktop\YAZILIM KURS DERS NOTLARIM\PROJE\Blog\Blog.Web\Areas\Adminn\Views\_ViewImports.cshtml"
using Blog.Web.Models.VMs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b0f863e92eccc9fb9f59f1791e47ce10407cdfd", @"/Areas/Adminn/Views/AppUser/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27678b6facafc98946fe5a665329736ebc86a9f5", @"/Areas/Adminn/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Adminn_Views_AppUser_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AppUser>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Onay", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<div class=""col-md-12"">
    <div class=""card"">
        <div class=""card-header p-2"">
            <ul class=""nav nav-pills"">
                <li class=""nav-item""><a class=""nav-link active"" href=""#activity"" data-toggle=""tab"">Onay Bekleyen</a></li>
                <li class=""nav-item""><a class=""nav-link"" href=""#timeline"" data-toggle=""tab"">Aktif</a></li>
                <li class=""nav-item""><a class=""nav-link"" href=""#settings"" data-toggle=""tab"">Pasif</a></li>
            </ul>
        </div><!-- /.card-header -->
        <div class=""card-body"">
            <div class=""tab-content"">
                <div class=""tab-pane active"" id=""activity"">
                    <section class=""content"">

                        <!-- Default box -->
                        <div class=""card"">
                            <div class=""card-body p-0"">
                                <table class=""table table-striped projects"">
                                    <thead>
                                        <tr>
");
            WriteLiteral(@"
                                            <th style=""width: 25%"" class=""text-center"">
                                                Image
                                            </th>
                                            <th style=""width: 25%"" class=""text-center"">
                                                First Name
                                            </th>
                                            <th style=""width: 25%"" class=""text-center"">
                                                Last Name
                                            </th>
                                            <th style=""width: 25%"" class=""text-center"">
                                                Operations
                                            </th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
#nullable restore
#line 39 "C:\Users\AYDOĞANLAR\Desktop\YAZILIM KURS DERS NOTLARIM\PROJE\Blog\Blog.Web\Areas\Adminn\Views\AppUser\List.cshtml"
                                         foreach (AppUser item in Model)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\AYDOĞANLAR\Desktop\YAZILIM KURS DERS NOTLARIM\PROJE\Blog\Blog.Web\Areas\Adminn\Views\AppUser\List.cshtml"
                                             if (item.Onay == Onay.UnApproved)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr>\r\n                                                    <td class=\"text-center\">\r\n                                                        <img");
            BeginWriteAttribute("src", " src=\"", 2416, "\"", 2433, 1);
#nullable restore
#line 45 "C:\Users\AYDOĞANLAR\Desktop\YAZILIM KURS DERS NOTLARIM\PROJE\Blog\Blog.Web\Areas\Adminn\Views\AppUser\List.cshtml"
WriteAttributeValue("", 2422, item.Image, 2422, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""img-circle elevation-2"" style=""height:50px;width:50px"">
                                                    </td>
                                                    <td class=""text-center"">
                                                        ");
#nullable restore
#line 48 "C:\Users\AYDOĞANLAR\Desktop\YAZILIM KURS DERS NOTLARIM\PROJE\Blog\Blog.Web\Areas\Adminn\Views\AppUser\List.cshtml"
                                                   Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td class=\"project_progress text-center\">\r\n                                                        ");
#nullable restore
#line 51 "C:\Users\AYDOĞANLAR\Desktop\YAZILIM KURS DERS NOTLARIM\PROJE\Blog\Blog.Web\Areas\Adminn\Views\AppUser\List.cshtml"
                                                   Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n\r\n                                                    <td class=\"project-state text-center\">\r\n                                                        <span class=\"badge badge-warning\">");
#nullable restore
#line 55 "C:\Users\AYDOĞANLAR\Desktop\YAZILIM KURS DERS NOTLARIM\PROJE\Blog\Blog.Web\Areas\Adminn\Views\AppUser\List.cshtml"
                                                                                     Write(item.Onay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                    </td>\r\n                                                    <td class=\"project-actions text-center\">\r\n                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b0f863e92eccc9fb9f59f1791e47ce10407cdfd10811", async() => {
                WriteLiteral("\r\n                                                            Onayla\r\n                                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "C:\Users\AYDOĞANLAR\Desktop\YAZILIM KURS DERS NOTLARIM\PROJE\Blog\Blog.Web\Areas\Adminn\Views\AppUser\List.cshtml"
                                                                               WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    </td>\r\n                                                </tr>\r\n");
#nullable restore
#line 63 "C:\Users\AYDOĞANLAR\Desktop\YAZILIM KURS DERS NOTLARIM\PROJE\Blog\Blog.Web\Areas\Adminn\Views\AppUser\List.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\AYDOĞANLAR\Desktop\YAZILIM KURS DERS NOTLARIM\PROJE\Blog\Blog.Web\Areas\Adminn\Views\AppUser\List.cshtml"
                                             

                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </tbody>
                                </table>
                            </div>
                            <!-- /.card-body -->
                        </div>
                        <!-- /.card -->

                    </section>
                </div>
                <!-- /.tab-pane -->
                <div class=""tab-pane"" id=""timeline"">
                    <section class=""content"">

                        <!-- Default box -->
                        <div class=""card"">
                            <div class=""card-body p-0"">
                                <table class=""table table-striped projects"">
                                    <thead>
                                        <tr>

                                            <th style=""width: 20%"" class=""text-center"">
                                                Image
                                            </th>
                                            <th style=""width: 20");
            WriteLiteral(@"%"" class=""text-center"">
                                                First Name
                                            </th>
                                            <th style=""width: 20%"" class=""text-center"">
                                                Last Name
                                            </th>

                                            <th style=""width: 10%"" class=""text-center"">
                                                Status
                                            </th>
                                            <th style=""width: 30%"" class=""text-center"">
                                                Operations
                                            </th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        

");
#nullable restore
#line 108 "C:\Users\AYDOĞANLAR\Desktop\YAZILIM KURS DERS NOTLARIM\PROJE\Blog\Blog.Web\Areas\Adminn\Views\AppUser\List.cshtml"
                                         foreach (AppUser item in Model)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "C:\Users\AYDOĞANLAR\Desktop\YAZILIM KURS DERS NOTLARIM\PROJE\Blog\Blog.Web\Areas\Adminn\Views\AppUser\List.cshtml"
                                             if (item.Onay ==Onay.Approved && (item.Statu==Statu.Active || item.Statu==Statu.Modified))
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr>\r\n                                                    <td class=\"text-center\">\r\n                                                        <img");
            BeginWriteAttribute("src", " src=\"", 6252, "\"", 6269, 1);
#nullable restore
#line 114 "C:\Users\AYDOĞANLAR\Desktop\YAZILIM KURS DERS NOTLARIM\PROJE\Blog\Blog.Web\Areas\Adminn\Views\AppUser\List.cshtml"
WriteAttributeValue("", 6258, item.Image, 6258, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""img-circle elevation-2"" style=""height:50px;width:50px"">
                                                    </td>
                                                    <td class=""text-center"">
                                                        ");
#nullable restore
#line 117 "C:\Users\AYDOĞANLAR\Desktop\YAZILIM KURS DERS NOTLARIM\PROJE\Blog\Blog.Web\Areas\Adminn\Views\AppUser\List.cshtml"
                                                   Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td class=\"project_progress text-center\">\r\n                                                        ");
#nullable restore
#line 120 "C:\Users\AYDOĞANLAR\Desktop\YAZILIM KURS DERS NOTLARIM\PROJE\Blog\Blog.Web\Areas\Adminn\Views\AppUser\List.cshtml"
                                                   Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n\r\n                                                    <td class=\"project-state text-center\">\r\n                                                        <span class=\"badge badge-success\">");
#nullable restore
#line 124 "C:\Users\AYDOĞANLAR\Desktop\YAZILIM KURS DERS NOTLARIM\PROJE\Blog\Blog.Web\Areas\Adminn\Views\AppUser\List.cshtml"
                                                                                     Write(item.Statu);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                                    </td>
                                                    <td class=""project-actions text-center"">
                                                        <a class=""btn btn-danger btn-sm"" href=""#"">
                                                            <i class=""fas fa-trash"">
                                                            </i>
                                                            Delete
                                                        </a>
                                                    </td>
                                                </tr>
");
#nullable restore
#line 134 "C:\Users\AYDOĞANLAR\Desktop\YAZILIM KURS DERS NOTLARIM\PROJE\Blog\Blog.Web\Areas\Adminn\Views\AppUser\List.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 134 "C:\Users\AYDOĞANLAR\Desktop\YAZILIM KURS DERS NOTLARIM\PROJE\Blog\Blog.Web\Areas\Adminn\Views\AppUser\List.cshtml"
                                             
                                           
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </tbody>
                                </table>
                            </div>
                            <!-- /.card-body -->
                        </div>
                        <!-- /.card -->

                    </section>
                </div>
                <!-- /.tab-pane -->

                <div class=""tab-pane"" id=""settings"">
                    <section class=""content"">

                        <!-- Default box -->
                        <div class=""card"">
                            <div class=""card-body p-0"">
                                <table class=""table table-striped projects"">
                                    <thead>
                                        <tr>

                                            <th style=""width: 20%"" class=""text-center"">
                                                Image
                                            </th>
                                            <th style=""width: ");
            WriteLiteral(@"20%"" class=""text-center"">
                                                First Name
                                            </th>
                                            <th style=""width: 20%"" class=""text-center"">
                                                Last Name
                                            </th>

                                            <th style=""width: 10%"" class=""text-center"">
                                                Status
                                            </th>
                                        </tr>
                                    </thead>
                                    <tbody>


");
#nullable restore
#line 177 "C:\Users\AYDOĞANLAR\Desktop\YAZILIM KURS DERS NOTLARIM\PROJE\Blog\Blog.Web\Areas\Adminn\Views\AppUser\List.cshtml"
                                         foreach (AppUser item in Model)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 179 "C:\Users\AYDOĞANLAR\Desktop\YAZILIM KURS DERS NOTLARIM\PROJE\Blog\Blog.Web\Areas\Adminn\Views\AppUser\List.cshtml"
                                             if (item.Onay == Onay.Approved && item.Statu == Statu.Passive)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr>\r\n                                                    <td class=\"text-center\">\r\n                                                        <img");
            BeginWriteAttribute("src", " src=\"", 9984, "\"", 10001, 1);
#nullable restore
#line 183 "C:\Users\AYDOĞANLAR\Desktop\YAZILIM KURS DERS NOTLARIM\PROJE\Blog\Blog.Web\Areas\Adminn\Views\AppUser\List.cshtml"
WriteAttributeValue("", 9990, item.Image, 9990, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""img-circle elevation-2"" style=""height:50px;width:50px"">
                                                    </td>
                                                    <td class=""text-center"">
                                                        ");
#nullable restore
#line 186 "C:\Users\AYDOĞANLAR\Desktop\YAZILIM KURS DERS NOTLARIM\PROJE\Blog\Blog.Web\Areas\Adminn\Views\AppUser\List.cshtml"
                                                   Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td class=\"project_progress text-center\">\r\n                                                        ");
#nullable restore
#line 189 "C:\Users\AYDOĞANLAR\Desktop\YAZILIM KURS DERS NOTLARIM\PROJE\Blog\Blog.Web\Areas\Adminn\Views\AppUser\List.cshtml"
                                                   Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n\r\n                                                    <td class=\"project-state text-center\">\r\n                                                        <span class=\"badge badge-success\">");
#nullable restore
#line 193 "C:\Users\AYDOĞANLAR\Desktop\YAZILIM KURS DERS NOTLARIM\PROJE\Blog\Blog.Web\Areas\Adminn\Views\AppUser\List.cshtml"
                                                                                     Write(item.Statu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                    </td>\r\n                                                </tr>\r\n");
#nullable restore
#line 196 "C:\Users\AYDOĞANLAR\Desktop\YAZILIM KURS DERS NOTLARIM\PROJE\Blog\Blog.Web\Areas\Adminn\Views\AppUser\List.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 196 "C:\Users\AYDOĞANLAR\Desktop\YAZILIM KURS DERS NOTLARIM\PROJE\Blog\Blog.Web\Areas\Adminn\Views\AppUser\List.cshtml"
                                             

                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </tbody>
                                </table>
                            </div>
                            <!-- /.card-body -->
                        </div>
                        <!-- /.card -->

                    </section>
                </div>
                <!-- /.tab-pane -->
            </div>
            <!-- /.tab-content -->
        </div><!-- /.card-body -->
    </div>
    <!-- /.card -->
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AppUser>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591