#pragma checksum "C:\Users\AYDOĞANLAR\Desktop\YAZILIM KURS DERS NOTLARIM\PROJE\Blog\Blog.Web\Views\Home\Hakkimizda.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2e17e48a322997b07a52f25d3b99971b645369e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Hakkimizda), @"mvc.1.0.view", @"/Views/Home/Hakkimizda.cshtml")]
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
#line 1 "C:\Users\AYDOĞANLAR\Desktop\YAZILIM KURS DERS NOTLARIM\PROJE\Blog\Blog.Web\Views\_ViewImports.cshtml"
using Blog.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AYDOĞANLAR\Desktop\YAZILIM KURS DERS NOTLARIM\PROJE\Blog\Blog.Web\Views\_ViewImports.cshtml"
using Blog.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AYDOĞANLAR\Desktop\YAZILIM KURS DERS NOTLARIM\PROJE\Blog\Blog.Web\Views\_ViewImports.cshtml"
using Blog.Web.Models.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AYDOĞANLAR\Desktop\YAZILIM KURS DERS NOTLARIM\PROJE\Blog\Blog.Web\Views\_ViewImports.cshtml"
using Blog.Web.Models.VMs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\AYDOĞANLAR\Desktop\YAZILIM KURS DERS NOTLARIM\PROJE\Blog\Blog.Web\Views\_ViewImports.cshtml"
using Blog.Model.Entities.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2e17e48a322997b07a52f25d3b99971b645369e", @"/Views/Home/Hakkimizda.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3506e456778563729a4191601f021fa5b02eeda5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Hakkimizda : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<List<Category>,List<AppUser>,List<Article>>>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("Header", async() => {
                WriteLiteral(@"
    <header class=""header"" id=""home"">
        <div class=""header pb-8 pt-5 pt-lg-8 d-flex align-items-center"" style=""min-height: 600px; background-image: url(https://raw.githubusercontent.com/creativetimofficial/argon-dashboard/gh-pages/assets-old/img/theme/profile-cover.jpg); background-size: cover; background-position: center top;"">
            <!-- Mask -->
");
                WriteLiteral("            <!-- Header container -->\r\n        </div>\r\n        <!-- Header-widget -->\r\n        <div class=\"widget\">\r\n            <div class=\"widget-item\">\r\n                <h2>");
#nullable restore
#line 14 "C:\Users\AYDOĞANLAR\Desktop\YAZILIM KURS DERS NOTLARIM\PROJE\Blog\Blog.Web\Views\Home\Hakkimizda.cshtml"
               Write(Model.Item2.Count());

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                <p>Adet Yazar</p>\r\n            </div>\r\n            <div class=\"widget-item\">\r\n                <h2>");
#nullable restore
#line 18 "C:\Users\AYDOĞANLAR\Desktop\YAZILIM KURS DERS NOTLARIM\PROJE\Blog\Blog.Web\Views\Home\Hakkimizda.cshtml"
               Write(Model.Item3.Count());

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                <p>Adet Makale</p>\r\n            </div>\r\n            <div class=\"widget-item\">\r\n                <h2>");
#nullable restore
#line 22 "C:\Users\AYDOĞANLAR\Desktop\YAZILIM KURS DERS NOTLARIM\PROJE\Blog\Blog.Web\Views\Home\Hakkimizda.cshtml"
               Write(Model.Item1.Count());

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                <p>Adet Kategori</p>\r\n            </div>\r\n        </div>\r\n    </header>\r\n   ");
            }
            );
            WriteLiteral(@"<div class=""responsive-container-block bigContainer"">
    <div class=""responsive-container-block Container"">
        <div class=""imgContainer"">
            <img class=""blueDots"" src=""https://workik-widget-assets.s3.amazonaws.com/widget-assets/images/aw3.svg"">
            <img class=""mainImg"" src=""https://workik-widget-assets.s3.amazonaws.com/widget-assets/images/aw2.svg"">
        </div>
        <div class=""responsive-container-block textSide"">
            <p class=""text-blk heading"">
                Hakkımızda
            </p>
            <p class=""text-blk subHeading"">
                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Eget purus lectus viverra in semper nec pretium mus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Eget purus lectus viverra in semper nec pretium mus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Eget purus lectus viverra in semper nec pretium mus. <br />
                Contrary to popular belief, Lorem Ipsum is not simply random text.");
            WriteLiteral(@" It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of ""de Finibus Bonorum et Malorum"" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, ""Lorem ipsum dolor sit amet.."", comes from a line in section 1.10.32.

                The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from ""de Finibus Bonorum et Malorum"" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.
          ");
            WriteLiteral("  </p>           \r\n        </div>\r\n        <img class=\"redDots\" src=\"https://workik-widget-assets.s3.amazonaws.com/widget-assets/images/cw3.svg\">\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Contact", async() => {
                WriteLiteral(@"
    <section id=""contact"" class=""position-relative section"">
        <div class=""container text-center"">
            <div class=""contact text-left"">
                <div class=""form"">
                    <h6 class=""section-title mb-4"">İletişim Formu</h6>
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2e17e48a322997b07a52f25d3b99971b645369e8645", async() => {
                    WriteLiteral("\r\n                        <div class=\"form-group\">\r\n                            <input type=\"email\" class=\"form-control\" id=\"exampleInputEmail1\" aria-describedby=\"emailHelp\" placeholder=\"Mail\"");
                    BeginWriteAttribute("required", " required=\"", 3839, "\"", 3850, 0);
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <input type=\"password\" class=\"form-control\" id=\"exampleInputPassword1\" placeholder=\"Şifre\"");
                    BeginWriteAttribute("required", " required=\"", 4054, "\"", 4065, 0);
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <textarea name=\"contact-message\"");
                    BeginWriteAttribute("id", " id=\"", 4211, "\"", 4216, 0);
                    EndWriteAttribute();
                    WriteLiteral(" cols=\"30\" rows=\"5\" class=\"form-control\" placeholder=\"Mesaj\"></textarea>\r\n                        </div>\r\n                        <button type=\"submit\" class=\"btn btn-primary btn-block rounded w-lg\">Mesaj Gönder</button>\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n                <div class=\"contact-infos\">\r\n                    <div class=\"item\">\r\n                        <i class=\"ti-location-pin\"></i>\r\n                        <div");
                BeginWriteAttribute("class", " class=\"", 4662, "\"", 4670, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            <h5>Adres</h5>
                            <p> Maslak, Kat: 5, Büyükdere Cd. No:237, 34398 Şişli/İstanbul</p>
                        </div>
                    </div>
                    <div class=""item"">
                        <i class=""ti-mobile""></i>
                        <div>
                            <h5>İletişim</h5>
                            <p>444 3 330</p>
                        </div>
                    </div>
                    <div class=""item"">
                        <i class=""ti-email""></i>
                        <div class=""mb-0"">
                            <h5>Mail Adresi</h5>
                            <p>info@bilgeadam.com</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div>
            <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3006.1137475162127!2d29.0244276!3d41.11020680000001!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3");
                WriteLiteral("m3!1m2!1s0x14cab5eaea73b441%3A0x75e77ec3ec7b8876!2sBilge%20Adam%20Kurumsal!5e0!3m2!1str!2str!4v1679825990258!5m2!1str!2str\" width=\"100%\" height=\"500\" style=\"border:0;\"");
                BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 5862, "\"", 5880, 0);
                EndWriteAttribute();
                WriteLiteral(" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>\r\n        </div>\r\n    </section>\r\n    <!-- End of Contact Section -->\r\n");
            }
            );
            DefineSection("Footer", async() => {
                WriteLiteral(@"
        <footer class=""footer"">
            <div class=""row align-items-center justify-content-xl-between"">
                <div class=""col-xl-6 m-auto text-center"">
                    <div class=""copyright"">
                        <p>Made with <a href=""https://www.creative-tim.com/product/argon-dashboard"" target=""_blank"">Argon Dashboard</a> by Creative Tim</p>
                    </div>
                </div>
            </div>
        </footer>

");
            }
            );
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<List<Category>,List<AppUser>,List<Article>>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
