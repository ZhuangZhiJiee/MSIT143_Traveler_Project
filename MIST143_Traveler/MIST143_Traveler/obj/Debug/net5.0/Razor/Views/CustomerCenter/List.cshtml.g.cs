#pragma checksum "E:\真期末專案\MIST143_Traveler\MIST143_Traveler\Views\CustomerCenter\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6915ab881864c96cf761170b26c0a1a9dde100ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CustomerCenter_List), @"mvc.1.0.view", @"/Views/CustomerCenter/List.cshtml")]
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
#line 1 "E:\真期末專案\MIST143_Traveler\MIST143_Traveler\Views\_ViewImports.cshtml"
using MIST143_Traveler;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\真期末專案\MIST143_Traveler\MIST143_Traveler\Views\_ViewImports.cshtml"
using MIST143_Traveler.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6915ab881864c96cf761170b26c0a1a9dde100ed", @"/Views/CustomerCenter/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbc1ad0dbcec2623da08a55ac030793acc2aab4f", @"/Views/_ViewImports.cshtml")]
    public class Views_CustomerCenter_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/客服中心.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/客服中心訂單內容物.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n\r\n");
            }
            );
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6915ab881864c96cf761170b26c0a1a9dde100ed4399", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6915ab881864c96cf761170b26c0a1a9dde100ed5513", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6915ab881864c96cf761170b26c0a1a9dde100ed6627", async() => {
                WriteLiteral(@"

    <article>
        <div class=""container p-5"">
            <div class=""row"">
                <div class=""col-12 col-md-3"">
                    <div class=""card"" style=""width: 18rem;"">
                        <div>
                            <img");
                BeginWriteAttribute("src", " src=\"", 391, "\"", 439, 1);
#nullable restore
#line 14 "E:\真期末專案\MIST143_Traveler\MIST143_Traveler\Views\CustomerCenter\List.cshtml"
WriteAttributeValue("", 397, Url.Content("~/images/contact/大頭貼修改.png"), 397, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                        </div>
                        <div class=""card-body mb-3"">
                            <h5 class=""card-title text-center"">橘子</h5>

                            <input type=""file"" class=""form-control"" id=""inputGroupFile02"">
                        </div>
                    </div>

                    

                    <div>
                        <div><button id=""btncus"" class=""btn btn-outline-warning 按鈕顏色2 active 選單""><span class=""bi bi-people 小圖示""></span>個人資訊</button></div>
                        <div>");
                WriteLiteral("</div>\r\n                        <div><button id=\"btnorder\" class=\"btn btn-outline-warning 按鈕顏色2\"><span class=\" bi bi-bag 小圖示\"></span>訂單管理</button></div>\r\n");
                WriteLiteral(@"                        <div><button id=""btnlove"" class=""btn btn-outline-warning 按鈕顏色2""><span class=""bi bi-heart 小圖示""></span>我的最愛</button></div>
                        <div><button id=""btnreview"" class=""btn btn-outline-warning 按鈕顏色2""><span class=""bi bi-chat-left-text 小圖示""></span>我的評論</button></div>
                        <div><button id=""btnstar"" class=""btn btn-outline-warning 按鈕顏色2""><span class=""bi bi-star 小圖示""></span>Star積分</button></div>
                        <div><button id=""btncop"" class=""btn btn-outline-warning 按鈕顏色2""><span class=""bi bi-wallet2 小圖示""></span>優惠票券</button></div>
                    </div>
                </div>

                <div id=""cont"" class=""col-12 col-md-9"">

                </div>
            </div>
        </div>

    </article>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(\'#cont\').load(\'");
#nullable restore
#line 47 "E:\真期末專案\MIST143_Traveler\MIST143_Traveler\Views\CustomerCenter\List.cshtml"
                    Write(Url.Content("~/CustomerCenter/CustomerInfo"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\')\r\n\r\n         $(\'#btncus\').click(function () {\r\n        $(\'#cont\').load(\'");
#nullable restore
#line 50 "E:\真期末專案\MIST143_Traveler\MIST143_Traveler\Views\CustomerCenter\List.cshtml"
                    Write(Url.Content("~/CustomerCenter/CustomerInfo"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"')
             $(this).addClass(""btn btn-outline-warning 按鈕顏色2 active"")//訂單按鈕
             $('#btnlove').removeClass(""active"")
             $('#btnreview').removeClass(""active"")
             $('#btnstar').removeClass(""active"")
             $('#btncop').removeClass(""active"")
             $('#btnorder').removeClass(""active"")
    })


    $('#btnorder').click(function () {
        $('#cont').load('");
#nullable restore
#line 61 "E:\真期末專案\MIST143_Traveler\MIST143_Traveler\Views\CustomerCenter\List.cshtml"
                    Write(Url.Content("~/CustomerCenter/ProductManage"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"')
        $(this).addClass(""btn btn-outline-warning 按鈕顏色2 active"")//訂單按鈕
        $('#btnlove').removeClass(""active"")
        $('#btnreview').removeClass(""active"")
        $('#btnstar').removeClass(""active"")
        $('#btncop').removeClass(""active"")
        $('#btncus').removeClass(""active"")
    })

    $('#btnlove').click(function () {
        $('#cont').load('");
#nullable restore
#line 71 "E:\真期末專案\MIST143_Traveler\MIST143_Traveler\Views\CustomerCenter\List.cshtml"
                    Write(Url.Content("~/CustomerCenter/Myfavorites"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"')
        $(this).addClass(""btn btn-outline-warning 按鈕顏色2 active"")
        $('#btnorder').removeClass(""active"")
        $('#btnreview').removeClass(""active"")
        $('#btnstar').removeClass(""active"")
        $('#btncop').removeClass(""active"")
        $('#btncus').removeClass(""active"")
        //我的最愛按鈕
        })

        $('#btnreview').click(function () {
        $('#cont').load('");
#nullable restore
#line 82 "E:\真期末專案\MIST143_Traveler\MIST143_Traveler\Views\CustomerCenter\List.cshtml"
                    Write(Url.Content("~/CustomerCenter/Review"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"')
            $(this).addClass(""btn btn-outline-warning 按鈕顏色2 active"") //我的評論按鈕
            $('#btnorder').removeClass(""active"")
            $('#btnlove').removeClass(""active"")
            $('#btnstar').removeClass(""active"")
            $('#btncop').removeClass(""active"")
            $('#btncus').removeClass(""active"")
        })

        $('#btnstar').click(function () {
        $('#cont').load('");
#nullable restore
#line 92 "E:\真期末專案\MIST143_Traveler\MIST143_Traveler\Views\CustomerCenter\List.cshtml"
                    Write(Url.Content("~/CustomerCenter/Star"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"')
            $(this).addClass(""btn btn-outline-warning 按鈕顏色2 active"") //Star
            $('#btnorder').removeClass(""active"")
            $('#btnlove').removeClass(""active"")
            $('#btnreview').removeClass(""active"")
            $('#btncop').removeClass(""active"")
            $('#btncus').removeClass(""active"")
        })

        $('#btncop').click(function () {
        $('#cont').load('");
#nullable restore
#line 102 "E:\真期末專案\MIST143_Traveler\MIST143_Traveler\Views\CustomerCenter\List.cshtml"
                    Write(Url.Content("~/CustomerCenter/Coupon"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"')
            $(this).addClass(""btn btn-outline-warning 按鈕顏色2 active"") //優惠券按鈕
            $('#btnorder').removeClass(""active"")
            $('#btnlove').removeClass(""active"")
            $('#btnreview').removeClass(""active"")
            $('#btnstar').removeClass(""active"")
            $('#btncus').removeClass(""active"")
        })


    

    </script>

");
            }
            );
            WriteLiteral("\r\n");
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
