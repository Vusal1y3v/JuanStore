#pragma checksum "C:\Users\Vusal\source\repos\JuanStore\JuanStore\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d05a225c5c949c10803639c4e5995ba52b553de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 1 "C:\Users\Vusal\source\repos\JuanStore\JuanStore\Views\_ViewImports.cshtml"
using JuanStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Vusal\source\repos\JuanStore\JuanStore\Views\_ViewImports.cshtml"
using JuanStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Vusal\source\repos\JuanStore\JuanStore\Views\_ViewImports.cshtml"
using JuanStore.ViewModels.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Vusal\source\repos\JuanStore\JuanStore\Views\_ViewImports.cshtml"
using JuanStore.ViewModels.Prodcut;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d05a225c5c949c10803639c4e5995ba52b553de", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c2b573fc1f29e0872ebaf29ba22bf1a45b2c0b8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("widget-search-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"  <!-- breadcrumb area start -->
<div class=""breadcrumb-area bg-img"" data-bg=""assets/img/banner/breadcrumb-banner.jpg"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""breadcrumb-wrap text-center"">
                    <nav aria-label=""breadcrumb"">
                        <h1 class=""breadcrumb-title"">Blog</h1>
                        <ul class=""breadcrumb"">
                            <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                            <li class=""breadcrumb-item active"" aria-current=""page"">Blog Left Sidebar</li>
                        </ul>
                    </nav>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- breadcrumb area end -->
<!-- blog main wrapper start -->
<div class=""blog-main-wrapper section-padding"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-3 order-2 order-lg-1"">
                <div class=");
            WriteLiteral(@"""blog-widget-wrapper"">
                    <!-- widget item start -->
                    <div class=""blog-widget"">
                        <div class=""blog-widget-img"">
                            <img src=""assets/img/blog/11.jpg"" alt=""author thumb"" />
                        </div>
                        <div class=""blog-author-title text-center"">
                            <h5>Erik Jhonson</h5>
                            <span>UI UX Designer</span>
                            <div class=""blog-widget-icon"">
                                <a href=""#""><i class=""fa fa-facebook""></i></a>
                                <a href=""#""><i class=""fa fa-twitter""></i></a>
                                <a href=""#""><i class=""fa fa-vimeo""></i></a>
                                <a href=""#""><i class=""fa fa-pinterest-p""></i></a>
                            </div>
                        </div>
                    </div>
                    <!-- widget item end -->
                    <!-- widget ite");
            WriteLiteral("m start -->\r\n                    <div class=\"blog-widget\">\r\n                        <h4 class=\"blog-widget-title\">Search</h4>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d05a225c5c949c10803639c4e5995ba52b553de6307", async() => {
                WriteLiteral("\r\n                            <input placeholder=\"Search keyword\" type=\"text\" class=\"search-field\">\r\n                            <button type=\"submit\" class=\"search-btn\"><i class=\"fa fa-search\"></i></button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <!-- widget item end -->
                    <!-- widget item start -->
                    <div class=""blog-widget"">
                        <h4 class=""blog-widget-title"">Recent Posts</h4>
                        <ul class=""recent-posts-inner"">
                            <li class=""recent-posts"">
                                <div class=""recent-posts-image"">
                                    <a href=""blog-details.html""><img src=""assets/img/blog/recent-01.jpg"" alt=""post thumb""></a>
                                </div>
                                <div class=""recent-posts-body"">
                                    <span class=""recent-posts-meta"">February  13,  2018</span>
                                    <h6 class=""recent-posts-title""><a href=""blog-details.html"">Diffrent title gose This is demo</a></h6>
                                </div>
                            </li>
                            <li class=""recent-posts"">
     ");
            WriteLiteral(@"                           <div class=""recent-posts-image"">
                                    <a href=""blog-details.html""><img src=""assets/img/blog/recent-02.jpg"" alt=""post thumb""></a>
                                </div>
                                <div class=""recent-posts-body"">
                                    <span class=""recent-posts-meta"">February  13,  2018</span>
                                    <h6 class=""recent-posts-title""><a href=""blog-details.html"">Diffrent title gose This is demo</a></h6>
                                </div>
                            </li>
                            <li class=""recent-posts"">
                                <div class=""recent-posts-image"">
                                    <a href=""blog-details.html""><img src=""assets/img/blog/recent-03.jpg"" alt=""post thumb""></a>
                                </div>
                                <div class=""recent-posts-body"">
                                    <span class=""recent-posts-meta""");
            WriteLiteral(@">February  13,  2018</span>
                                    <h6 class=""recent-posts-title""><a href=""blog-details.html"">Diffrent title gose This is demo</a></h6>
                                </div>
                            </li>
                            <li class=""recent-posts"">
                                <div class=""recent-posts-image"">
                                    <a href=""blog-details.html""><img src=""assets/img/blog/recent-04.jpg"" alt=""post thumb""></a>
                                </div>
                                <div class=""recent-posts-body"">
                                    <span class=""recent-posts-meta"">February  13,  2018</span>
                                    <h6 class=""recent-posts-title""><a href=""blog-details.html"">Diffrent title gose This is demo</a></h6>
                                </div>
                            </li>
                        </ul>
                    </div>
                    <!-- widget item end -->
              ");
            WriteLiteral(@"      <!-- widget item start -->
                    <div class=""blog-widget"">
                        <h4 class=""blog-widget-title"">Categories</h4>
                        <ul class=""blog-categories"">
                            <li><a href=""blog-details.html"">Shoes</a><span>(20)</span></li>
                            <li><a href=""blog-details.html"">Fashion</a><span>(18)</span></li>
                            <li><a href=""blog-details.html"">Wallet</a><span>(40)</span></li>
                            <li><a href=""blog-details.html"">Life Style</a><span>(66)</span></li>
                            <li><a href=""blog-details.html"">Electronics</a><span>(66)</span></li>
                            <li><a href=""blog-details.html"">Jewellery & Cosmetics</a><span>(30)</span></li>
                        </ul>
                    </div>
                    <!-- widget item end -->
                    <!-- widget item start -->
                    <div class=""blog-widget"">
                        <h4 cl");
            WriteLiteral(@"ass=""blog-widget-title"">Tags</h4>
                        <div class=""blog-tag"">
                            <a href=""blog-details.html"">Fashion</a>
                            <a href=""blog-details.html"">Shoes</a>
                            <a href=""blog-details.html"">Wallet</a>
                            <a href=""blog-details.html"">Bags</a>
                            <a href=""blog-details.html"">Jewelery</a>
                        </div>
                    </div>
                    <!-- widget item end -->
                </div>
            </div>
            <div class=""col-lg-9 order-1 order-lg-2"">
                <div class=""row"">
                    <div class=""col-md-6"">
                        <!-- blog single item start -->
                        <div class=""blog-post-item mb-30"">
                            <div class=""blog-thumb"">
                                <a href=""blog-details.html"">
                                    <img src=""assets/img/blog/blog-1.jpg"" alt=""blog ");
            WriteLiteral(@"thumb"">
                                </a>
                            </div>
                            <div class=""blog-content"">
                                <h5 class=""blog-title"">
                                    <a href=""blog-details.html"">
                                        Celebrity Daughter Opens About Upto Having Her Eye
                                    </a>
                                </h5>
                                <ul class=""blog-meta"">
                                    <li><span>By: </span>Admin,</li>
                                    <li><span>On: </span>14.07.2029</li>
                                </ul>
                                <a href=""blog-details.html"" class=""read-more"">Read More...</a>
                            </div>
                        </div>
                        <!-- blog single item start -->
                    </div>
                    <div class=""col-md-6"">
                        <!-- blog single item start -->
");
            WriteLiteral(@"                        <div class=""blog-post-item mb-30"">
                            <div class=""blog-thumb"">
                                <a href=""blog-details.html"">
                                    <img src=""assets/img/blog/blog-2.jpg"" alt=""blog thumb"">
                                </a>
                            </div>
                            <div class=""blog-content"">
                                <h5 class=""blog-title"">
                                    <a href=""blog-details.html"">
                                        Sotto Winner Offering Up Money To Any Man That Will Date Her
                                    </a>
                                </h5>
                                <ul class=""blog-meta"">
                                    <li><span>By: </span>Admin,</li>
                                    <li><span>On: </span>14.07.2029</li>
                                </ul>
                                <a href=""blog-details.html"" class=""read-more"">Re");
            WriteLiteral(@"ad More...</a>
                            </div>
                        </div>
                        <!-- blog single item start -->
                    </div>
                    <div class=""col-md-6"">
                        <!-- blog single item start -->
                        <div class=""blog-post-item mb-30"">
                            <div class=""blog-thumb embed-responsive embed-responsive-16by9"">
                                <iframe src=""https://www.youtube.com/embed/4qNHr0W6F0o"" allow=""autoplay; encrypted-media"" allowfullscreen></iframe>
                            </div>
                            <div class=""blog-content"">
                                <h5 class=""blog-title"">
                                    <a href=""blog-details.html"">
                                        Children Left Home Alone For 4 Days In TV Series Experiment
                                    </a>
                                </h5>
                                <ul class=""blog-meta"">");
            WriteLiteral(@"
                                    <li><span>By: </span>Admin,</li>
                                    <li><span>On: </span>14.07.2029</li>
                                </ul>
                                <a href=""blog-details.html"" class=""read-more"">Read More...</a>
                            </div>
                        </div>
                        <!-- blog single item start -->
                    </div>
                    <div class=""col-md-6"">
                        <!-- blog single item start -->
                        <div class=""blog-post-item mb-30"">
                            <div class=""blog-thumb embed-responsive embed-responsive-16by9"">
                                <iframe src=""https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/501298839&amp;color=%23ff5500&amp;auto_play=false&amp;hide_related=true&amp;show_comments=false&amp;show_user=true&amp;show_reposts=false&amp;show_teaser=true&amp;visual=true""></iframe>
                            </");
            WriteLiteral(@"div>
                            <div class=""blog-content"">
                                <h5 class=""blog-title"">
                                    <a href=""blog-details.html"">
                                        People Are Willing Lie When To Comes Money Research from
                                    </a>
                                </h5>
                                <ul class=""blog-meta"">
                                    <li><span>By: </span>Admin,</li>
                                    <li><span>On: </span>14.07.2029</li>
                                </ul>
                                <a href=""blog-details.html"" class=""read-more"">Read More...</a>
                            </div>
                        </div>
                        <!-- blog single item start -->
                    </div>
                    <div class=""col-md-6"">
                        <!-- blog single item start -->
                        <div class=""blog-post-item mb-30"">
           ");
            WriteLiteral(@"                 <div class=""blog-thumb"">
                                <a href=""blog-details.html"">
                                    <img src=""assets/img/blog/blog-3.jpg"" alt=""blog thumb"">
                                </a>
                            </div>
                            <div class=""blog-content"">
                                <h5 class=""blog-title"">
                                    <a href=""blog-details.html"">
                                        Romantic Love Stories Of Hollywood Popular Celebrities
                                    </a>
                                </h5>
                                <ul class=""blog-meta"">
                                    <li><span>By: </span>Admin,</li>
                                    <li><span>On: </span>14.07.2029</li>
                                </ul>
                                <a href=""blog-details.html"" class=""read-more"">Read More...</a>
                            </div>
                        <");
            WriteLiteral(@"/div>
                        <!-- blog single item start -->
                    </div>
                    <div class=""col-md-6"">
                        <!-- blog single item start -->
                        <div class=""blog-post-item mb-30"">
                            <div class=""blog-thumb"">
                                <a href=""blog-details.html"">
                                    <img src=""assets/img/blog/blog-4.jpg"" alt=""blog thumb"">
                                </a>
                            </div>
                            <div class=""blog-content"">
                                <h5 class=""blog-title"">
                                    <a href=""blog-details.html"">
                                        Celebrity Daughter Opens About Upto Having Her Eye
                                    </a>
                                </h5>
                                <ul class=""blog-meta"">
                                    <li><span>By: </span>Admin,</li>
          ");
            WriteLiteral(@"                          <li><span>On: </span>14.07.2029</li>
                                </ul>
                                <a href=""blog-details.html"" class=""read-more"">Read More...</a>
                            </div>
                        </div>
                        <!-- blog single item start -->
                    </div>
                </div>
                <!-- start pagination area -->
                <div class=""paginatoin-area text-center"">
                    <ul class=""pagination-box"">
                        <li><a class=""Previous"" href=""#""><i class=""ion-ios-arrow-left""></i></a></li>
                        <li class=""active""><a href=""#"">1</a></li>
                        <li><a href=""#"">2</a></li>
                        <li><a href=""#"">3</a></li>
                        <li><a class=""Next"" href=""#""><i class=""ion-ios-arrow-right""></i></a></li>
                    </ul>
                </div>
                <!-- end pagination area -->
            </div>
   ");
            WriteLiteral("     </div>\r\n    </div>\r\n</div>\r\n<!-- blog main wrapper end -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
