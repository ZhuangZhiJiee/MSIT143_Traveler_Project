#pragma checksum "C:\Users\莊智傑\source\repos\MSIT143_Traveler_Project\MIST143_Traveler\MIST143_Traveler\Views\Shopping\ShoppingCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d7b1063c8bbd4b6bdbbe51168de67ff05d02a9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shopping_ShoppingCart), @"mvc.1.0.view", @"/Views/Shopping/ShoppingCart.cshtml")]
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
#line 1 "C:\Users\kooh\Desktop\Proj\MIST143_Traveler\MIST143_Traveler\Views\_ViewImports.cshtml"
using MIST143_Traveler;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kooh\Desktop\Proj\MIST143_Traveler\MIST143_Traveler\Views\_ViewImports.cshtml"
using MIST143_Traveler.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d7b1063c8bbd4b6bdbbe51168de67ff05d02a9e", @"/Views/Shopping/ShoppingCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbc1ad0dbcec2623da08a55ac030793acc2aab4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shopping_ShoppingCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/travelOrder.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/travelOrder.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\kooh\Desktop\Proj\MIST143_Traveler\MIST143_Traveler\Views\Shopping\ShoppingCart.cshtml"
  
    ViewData["Title"] = "ShoppingCart";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9d7b1063c8bbd4b6bdbbe51168de67ff05d02a9e4841", async() => {
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
            }
            );
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d7b1063c8bbd4b6bdbbe51168de67ff05d02a9e6042", async() => {
                WriteLiteral(@"
    <article class=""payContainer"">
        <div class=""payContainerInner"">
            <h3 class=""subTitle py-3"">購物車</h3>
            <div>
                <div class=""row"">
                    <div class=""col-9"">
                        <div class=""leftSide p-3 paddingMore"">
                            <input class=""form-check-input mt-0 "" type=""checkbox""");
                BeginWriteAttribute("value", " value=\"", 512, "\"", 520, 0);
                EndWriteAttribute();
                WriteLiteral(@"
                                   aria-label=""Checkbox for following text input"">
                            <span class=""ms-2"">全選</span>
                            <a class=""ms-3 buttonA"">刪除選中活動</a>
                        </div>
                        <div class=""leftSide p-3 paddingMore"">
                            <div class=""shoppingCartInfoRow"">
                                <input class=""form-check-input mt-0 "" type=""checkbox""");
                BeginWriteAttribute("value", " value=\"", 973, "\"", 981, 0);
                EndWriteAttribute();
                WriteLiteral("\r\n                                       aria-label=\"Checkbox for following text input\">\r\n                                <div class=\"imgBox ms-3\">\r\n");
                WriteLiteral(@"                                </div>
                                <div class=""infoBox ms-1 px-3"">
                                    <div class=""titleFontStyle"">
                                        【領券現折100】Klook獨家優惠｜台北101觀景台門票｜萬聖節搗蛋派對｜高空Sky Lounge百萬夜景
                                    </div>
                                    <div class=""subInfoText"">
                                        方案類型:【台北101觀景台】最High夜景-搗蛋派對星光票

                                    </div>
                                </div>
                                <div class=""subInfoText"">
                                    2022年10月11日 10:00AM<br>
                                    當地時間
                                </div>
                                <div class=""chooseNumber ps-1"">
                                    <div class=""subtext"">每人</div>
                                    <div class=""chooseNumberBlock"">
                                        <button type=""button"" id=""childMinus""
          ");
                WriteLiteral(@"                                      class=""btn btn-outline-secondary"">
                                            -
                                        </button>
                                        <div class=""number"" id=""childNum"">1</div>
                                        <button type=""button"" id=""childPlus""
                                                class=""btn btn-outline-secondary"">
                                            +
                                        </button>
                                    </div>
                                </div>
                            </div>
                            <div class=""border-bottom-line my-3""></div>
                            <div class=""shoppingCartInfoRowbottomRow"">
                                <div>
                                    <a class=""buttonA"" href=""./travelPayCheckout.html"">編輯</a> |
                                    <a class=""buttonA"">刪除</a>
                                </div>
     ");
                WriteLiteral(@"                           <div class=""titleFontStyle"">NT$ <span id=""shoppingCartTotalPrice"">300</span></div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-3 "">
                        <div class=""rightSide "">
                            <div class=""subInfoText"">1件總計 <i class=""bi bi-caret-down""></i></div>
                            <div class=""titleFontStyle"">NT$ <span id=""totalPayPrice"">300</span></div>
                            <button type=""button"" class=""btn btn-main my-3 fullSize"" id=""goPayBtn"">
                                <a class=""buttonInnderA"" href=""../Shopping/PayData"">結帳</a>
                            </button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </article>
");
                DefineSection("Scripts", async() => {
                    WriteLiteral(@"
        <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/js/bootstrap.bundle.min.js""></script>
        <script src=""https://code.jquery.com/jquery-3.6.1.js""
                integrity=""sha256-3zlB5s2uwoUzrXK3BT7AX3FyvojsraNFxCc2vC/7pNI="" crossorigin=""anonymous""></script>
        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d7b1063c8bbd4b6bdbbe51168de67ff05d02a9e11105", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n    ");
                }
                );
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n\r\n\r\n");
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
