#pragma checksum "C:\Users\Student\source\repos\1011MSIT143_Traveler_Project\MIST143_Traveler\MIST143_Traveler\Views\CustomerCenter\LoginModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74742b44028d314ee943a47c86d231837174d82c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CustomerCenter_LoginModal), @"mvc.1.0.view", @"/Views/CustomerCenter/LoginModal.cshtml")]
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
#line 1 "C:\Users\Student\source\repos\1011MSIT143_Traveler_Project\MIST143_Traveler\MIST143_Traveler\Views\_ViewImports.cshtml"
using MIST143_Traveler;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Student\source\repos\1011MSIT143_Traveler_Project\MIST143_Traveler\MIST143_Traveler\Views\_ViewImports.cshtml"
using MIST143_Traveler.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74742b44028d314ee943a47c86d231837174d82c", @"/Views/CustomerCenter/LoginModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbc1ad0dbcec2623da08a55ac030793acc2aab4f", @"/Views/_ViewImports.cshtml")]
    public class Views_CustomerCenter_LoginModal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\Student\source\repos\1011MSIT143_Traveler_Project\MIST143_Traveler\MIST143_Traveler\Views\CustomerCenter\LoginModal.cshtml"
  
    ViewData["Title"] = "LoginModal";
    Layout = null;
    


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74742b44028d314ee943a47c86d231837174d82c4001", async() => {
                WriteLiteral(@"
    <h1>歡迎</h1>
    <div class=""mb-3"">
        <label for=""exampleFormControlInput1"" class=""form-label"">使用者帳號</label>
        <input type=""text"" class=""form-control"" id=""Actemail"" placeholder=""name@example.com"">
        <small id=""sm"" class=""form-text text-muted""></small>
    </div>
    <div class=""mb-3"">
        <label for=""exampleFormControlInput1"" class=""form-label"">使用者密碼</label>
        <input type=""password"" class=""form-control"" id=""Pas"" placeholder=""password"">
    </div>
    <div class=""modal-footer mx-auto"">
        <div style=""margin-right:150px;"">
            <span>
                <label>
                    <span>
                        <input type=""checkbox"" />
                    </span>
                    <span>記住我</span>
                </label>
            </span>
        </div>
        <button type=""submit"" class=""btn btn-primary"" id=""btnlogin"" onclick=""BtnLogin()"">登入</button>
        <button type=""button"" class=""btn btn-success"" id="" demo"" onclick=""DemoValue()"">Demo");
                WriteLiteral("</button>\r\n        <a");
                BeginWriteAttribute("href", " href=\"", 1145, "\"", 1194, 1);
#nullable restore
#line 34 "C:\Users\Student\source\repos\1011MSIT143_Traveler_Project\MIST143_Traveler\MIST143_Traveler\Views\CustomerCenter\LoginModal.cshtml"
WriteAttributeValue("", 1152, Url.Content("~/CustomerCenter/Forgetpas"), 1152, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn-outline-dark\">忘記密碼?</a>\r\n\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        //const login = document.querySelector(\"#btnlogin\");\r\n        //login.addEventListener(\"\")\r\n\r\n\r\n    </script>\r\n");
            }
            );
            WriteLiteral(@"
<script>
        const DemoValue = () => {
         let act = document.querySelector(""#Actemail"");
        let pas = document.querySelector(""#Pas"");
        act.value = ""mi@123.com"";
        pas.value = 12345678;
        
    }

    const BtnLogin = () => {
            alert(""登入成功"")
        }
</script>
   

");
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
