#pragma checksum "C:\Users\syabd\Documents\GitHub\Std.Tyot\Web.UI.Mvc.Core\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30d883bdb145eff286991ad67600c0d61ec3ad45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\syabd\Documents\GitHub\Std.Tyot\Web.UI.Mvc.Core\Views\_ViewImports.cshtml"
using Web.UI.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\syabd\Documents\GitHub\Std.Tyot\Web.UI.Mvc.Core\Views\_ViewImports.cshtml"
using Web.UI.Mvc.Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30d883bdb145eff286991ad67600c0d61ec3ad45", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd5de1e5f10b6ef6368913ee0f0ceea581929a5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/about.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/brands/placeholder_brands.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("owl-lazy"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\syabd\Documents\GitHub\Std.Tyot\Web.UI.Mvc.Core\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("_pageStyle", async() => {
                WriteLiteral("\r\n    <!-- SPECIFIC CSS -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "30d883bdb145eff286991ad67600c0d61ec3ad455282", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
            }
            );
            WriteLiteral(@"
<main>
    <div id=""carousel-home"">
        <div class=""owl-carousel owl-theme"">
            <div class=""owl-slide cover"" style=""background-image: url(img/slides/slide_home_2.jpg);"">
                <div class=""opacity-mask d-flex align-items-center"" data-opacity-mask=""rgba(0, 0, 0, 0.5)"">
                    <div class=""container"">
                        <div class=""row justify-content-center justify-content-md-end"">
                            <div class=""col-lg-6 static"">
                                <div class=""slide-text text-right white"">
                                    <h2 class=""owl-slide-animated owl-slide-title"">Attack Air<br>Max 720 Sage Low</h2>
                                    <p class=""owl-slide-animated owl-slide-subtitle"">
                                        Limited items available at this price
                                    </p>
                                    <div class=""owl-slide-animated owl-slide-cta""><a class=""btn_1"" href=""listing-grid-1-full.html""");
            WriteLiteral(@" role=""button"">Shop Now</a></div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!--/owl-slide-->
            <div class=""owl-slide cover"" style=""background-image: url(img/slides/slide_home_1.jpg);"">
                <div class=""opacity-mask d-flex align-items-center"" data-opacity-mask=""rgba(0, 0, 0, 0.5)"">
                    <div class=""container"">
                        <div class=""row justify-content-center justify-content-md-start"">
                            <div class=""col-lg-6 static"">
                                <div class=""slide-text white"">
                                    <h2 class=""owl-slide-animated owl-slide-title"">Attack Air<br>VaporMax Flyknit 3</h2>
                                    <p class=""owl-slide-animated owl-slide-subtitle"">
                                        Limited items available at this price
                   ");
            WriteLiteral(@"                 </p>
                                    <div class=""owl-slide-animated owl-slide-cta""><a class=""btn_1"" href=""listing-grid-1-full.html"" role=""button"">Shop Now</a></div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!--/owl-slide-->
            <div class=""owl-slide cover"" style=""background-image: url(img/slides/slide_home_3.jpg);"">
                <div class=""opacity-mask d-flex align-items-center"" data-opacity-mask=""rgba(255, 255, 255, 0.5)"">
                    <div class=""container"">
                        <div class=""row justify-content-center justify-content-md-start"">
                            <div class=""col-lg-12 static"">
                                <div class=""slide-text text-center black"">
                                    <h2 class=""owl-slide-animated owl-slide-title"">Attack Air<br>Monarch IV SE</h2>
                  ");
            WriteLiteral(@"                  <p class=""owl-slide-animated owl-slide-subtitle"">
                                        Lightweight cushioning and durable support with a Phylon midsole
                                    </p>
                                    <div class=""owl-slide-animated owl-slide-cta""><a class=""btn_1"" href=""listing-grid-1-full.html"" role=""button"">Shop Now</a></div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!--/owl-slide-->
            </div>
        </div>
        <div id=""icon_drag_mobile""></div>
    </div>
    <!--/carousel-->

    <ul id=""banners_grid"" class=""clearfix"">
        <li>
            <a href=""#0"" class=""img_container"">
                <img src=""img/banners_cat_placeholder.jpg"" data-src=""img/banner_1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4158, "\"", 4164, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""lazy"">
                <div class=""short_info opacity-mask"" data-opacity-mask=""rgba(0, 0, 0, 0.5)"">
                    <h3>Men's Collection</h3>
                    <div><span class=""btn_1"">Shop Now</span></div>
                </div>
            </a>
        </li>
        <li>
            <a href=""#0"" class=""img_container"">
                <img src=""img/banners_cat_placeholder.jpg"" data-src=""img/banner_2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4596, "\"", 4602, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""lazy"">
                <div class=""short_info opacity-mask"" data-opacity-mask=""rgba(0, 0, 0, 0.5)"">
                    <h3>Womens's Collection</h3>
                    <div><span class=""btn_1"">Shop Now</span></div>
                </div>
            </a>
        </li>
        <li>
            <a href=""#0"" class=""img_container"">
                <img src=""img/banners_cat_placeholder.jpg"" data-src=""img/banner_3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5037, "\"", 5043, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""lazy"">
                <div class=""short_info opacity-mask"" data-opacity-mask=""rgba(0, 0, 0, 0.5)"">
                    <h3>Kids's Collection</h3>
                    <div><span class=""btn_1"">Shop Now</span></div>
                </div>
            </a>
        </li>
    </ul>
    <!--/banners_grid -->

    <div class=""bg_gray"">
        <div class=""container margin_30"">
            <div id=""brands"" class=""owl-carousel owl-theme"">
                <div class=""item"">
                    <a href=""#0"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "30d883bdb145eff286991ad67600c0d61ec3ad4512534", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                </div><!-- /item -->\r\n                <div class=\"item\">\r\n                    <a href=\"#0\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "30d883bdb145eff286991ad67600c0d61ec3ad4513851", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                </div><!-- /item -->\r\n                <div class=\"item\">\r\n                    <a href=\"#0\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "30d883bdb145eff286991ad67600c0d61ec3ad4515168", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                </div><!-- /item -->\r\n                <div class=\"item\">\r\n                    <a href=\"#0\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "30d883bdb145eff286991ad67600c0d61ec3ad4516485", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                </div><!-- /item -->\r\n                <div class=\"item\">\r\n                    <a href=\"#0\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "30d883bdb145eff286991ad67600c0d61ec3ad4517802", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                </div><!-- /item -->\r\n                <div class=\"item\">\r\n                    <a href=\"#0\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "30d883bdb145eff286991ad67600c0d61ec3ad4519119", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a>
                </div><!-- /item -->
            </div><!-- /carousel -->
        </div><!-- /container -->
    </div>
    <!-- /bg_gray -->
    <div class=""bg_gray"">
        <div id=""carousel-home"">
            <div class=""owl-carousel owl-theme"">
                <div class=""owl-slide cover "" style=""background-image: url(../../wwwroot/img/testimonial_1.jpg);"">
                    <div class=""opacity-mask d-flex align-items-center"" data-opacity-mask=""rgba(255, 255, 255, 0.5)"">
                        <div class=""container"">
                            <div class=""row justify-content-center justify-content-md-start"">
                                <div class=""col-lg-12 static"">
                                    <div class=""slide-text text-center black"">
                                        <h2 class=""owl-slide-animated owl-slide-title"">""Satisfied""</h2>
                                        <p class=""owl-slide-animated owl-slide-subtitle"">
                                          ");
            WriteLiteral(@"  <em>His dolor docendi fuisset ad, movet mucius diceret et qui. Esse ferri integre sit id.</em>
                                        </p>
                                        <div class=""owl-slide-animated owl-slide-cta"">Katrin - Student</div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!--/owl-slide-->
                </div>
                <div class=""owl-slide cover"" style=""background-image: url(../../wwwroot/img/testimonial_2.jpg);"">
                    <div class=""opacity-mask d-flex align-items-center"" data-opacity-mask=""rgba(255, 255, 255, 0.5)"">
                        <div class=""container"">
                            <div class=""row justify-content-center justify-content-md-start"">
                                <div class=""col-lg-12 static"">
                                    <div class=""slide-text text-center black"">
     ");
            WriteLiteral(@"                                   <h2 class=""owl-slide-animated owl-slide-title"">""Satisfied""</h2>
                                        <p class=""owl-slide-animated owl-slide-subtitle"">
                                            <em>His dolor docendi fuisset ad, movet mucius diceret et qui. Esse ferri integre sit id.</em>
                                        </p>
                                        <div class=""owl-slide-animated owl-slide-cta"">Katrin - Student</div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!--/owl-slide-->
                </div>
                <div class=""owl-slide cover"" style=""background-image: url(../../wwwroot/img/testimonial_3.jpg);"">
                    <div class=""opacity-mask d-flex align-items-center"" data-opacity-mask=""rgba(255, 255, 255, 0.5)"">
                        <div class=""container"">
           ");
            WriteLiteral(@"                 <div class=""row justify-content-center justify-content-md-start"">
                                <div class=""col-lg-12 static"">
                                    <div class=""slide-text text-center black"">
                                        <h2 class=""owl-slide-animated owl-slide-title"">""Satisfied""</h2>
                                        <p class=""owl-slide-animated owl-slide-subtitle"">
                                            <em>His dolor docendi fuisset ad, movet mucius diceret et qui. Esse ferri integre sit id.</em>
                                        </p>
                                        <div class=""owl-slide-animated owl-slide-cta"">Katrin - Student</div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!--/owl-slide-->
                </div>
                <div class=""owl-slide cover"" style=""backgroun");
            WriteLiteral(@"d-image: url(../../wwwroot/img/testimonial_1.jpg);"">
                    <div class=""opacity-mask d-flex align-items-center"" data-opacity-mask=""rgba(255, 255, 255, 0.5)"">
                        <div class=""container"">
                            <div class=""row justify-content-center justify-content-md-start"">
                                <div class=""col-lg-12 static"">
                                    <div class=""slide-text text-center black"">
                                        <h2 class=""owl-slide-animated owl-slide-title"">""Satisfied""</h2>
                                        <p class=""owl-slide-animated owl-slide-subtitle"">
                                            <em>His dolor docendi fuisset ad, movet mucius diceret et qui. Esse ferri integre sit id.</em>
                                        </p>
                                        <div class=""owl-slide-animated owl-slide-cta"">Katrin - Student</div>
                                    </div>
                           ");
            WriteLiteral(@"     </div>
                            </div>
                        </div>
                    </div>
                    <!--/owl-slide-->
                </div>
            </div>
            <div id=""icon_drag_mobile""></div>
        </div>
    </div>
    <!-- /container -->
    <div class=""container margin_60_35"">
        <div class=""main_title"">
            <h2>Latest news</h2>
            <span>Blog</span>
            <p>Cum doctus civibus efficiantur in imperdiet deterruisset</p>
        </div>
        <div class=""row"">
            <div class=""col-lg-6"">
                <a class=""box_news"" href=""blog.html"">
                    <figure>
                        <img src=""img/blog-thumb-placeholder.jpg"" data-src=""img/blog-thumb-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 12450, "\"", 12456, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""400"" height=""266"" class=""lazy"">
                        <figcaption><strong>28</strong>Dec</figcaption>
                    </figure>
                    <ul>
                        <li>by Mark Twain</li>
                        <li>20.11.2017</li>
                    </ul>
                    <h4>Pri oportere scribentur eu</h4>
                    <p>Cu eum alia elit, usu in eius appareat, deleniti sapientem honestatis eos ex. In ius esse ullum vidisse....</p>
                </a>
            </div>
            <!-- /box_news -->
            <div class=""col-lg-6"">
                <a class=""box_news"" href=""blog.html"">
                    <figure>
                        <img src=""img/blog-thumb-placeholder.jpg"" data-src=""img/blog-thumb-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 13233, "\"", 13239, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""400"" height=""266"" class=""lazy"">
                        <figcaption><strong>28</strong>Dec</figcaption>
                    </figure>
                    <ul>
                        <li>By Jhon Doe</li>
                        <li>20.11.2017</li>
                    </ul>
                    <h4>Duo eius postea suscipit ad</h4>
                    <p>Cu eum alia elit, usu in eius appareat, deleniti sapientem honestatis eos ex. In ius esse ullum vidisse....</p>
                </a>
            </div>
            <!-- /box_news -->
            <div class=""col-lg-6"">
                <a class=""box_news"" href=""blog.html"">
                    <figure>
                        <img src=""img/blog-thumb-placeholder.jpg"" data-src=""img/blog-thumb-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 14015, "\"", 14021, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""400"" height=""266"" class=""lazy"">
                        <figcaption><strong>28</strong>Dec</figcaption>
                    </figure>
                    <ul>
                        <li>By Luca Robinson</li>
                        <li>20.11.2017</li>
                    </ul>
                    <h4>Elitr mandamus cu has</h4>
                    <p>Cu eum alia elit, usu in eius appareat, deleniti sapientem honestatis eos ex. In ius esse ullum vidisse....</p>
                </a>
            </div>
            <!-- /box_news -->
            <div class=""col-lg-6"">
                <a class=""box_news"" href=""blog.html"">
                    <figure>
                        <img src=""img/blog-thumb-placeholder.jpg"" data-src=""img/blog-thumb-4.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 14796, "\"", 14802, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""400"" height=""266"" class=""lazy"">
                        <figcaption><strong>28</strong>Dec</figcaption>
                    </figure>
                    <ul>
                        <li>By Paula Rodrigez</li>
                        <li>20.11.2017</li>
                    </ul>
                    <h4>Id est adhuc ignota delenit</h4>
                    <p>Cu eum alia elit, usu in eius appareat, deleniti sapientem honestatis eos ex. In ius esse ullum vidisse....</p>
                </a>
            </div>
            <!-- /box_news -->
        </div>
        <!-- /row -->
    </div>
    <!-- /container -->
</main>
<!-- /main -->

");
            DefineSection("_pageScripts", async() => {
                WriteLiteral("\r\n\r\n\r\n\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591