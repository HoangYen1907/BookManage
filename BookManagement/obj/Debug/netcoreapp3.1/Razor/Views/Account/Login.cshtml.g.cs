#pragma checksum "D:\VS_Net2\BookManage\BookManagement\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d442eb791642ef1b67d54edb40ae72e92280f64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
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
#line 1 "D:\VS_Net2\BookManage\BookManagement\Views\_ViewImports.cshtml"
using BookManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VS_Net2\BookManage\BookManagement\Views\_ViewImports.cshtml"
using BookManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d442eb791642ef1b67d54edb40ae72e92280f64", @"/Views/Account/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a3096475496e018f050ad657f055d832dbd214d", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "D:\VS_Net2\BookManage\BookManagement\Views\Account\Login.cshtml"
  
    Layout = "_LayoutLogin";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card\" style=\"border:none;\">\r\n    <div class=\"container\" style=\"border: 1px solid #c2bfbf; width:500px; margin-top:150px; border-radius:10px;\">\r\n        <h2 class=\"text-center\" style=\"margin-top:10px;\">????ng nh???p</h2>\r\n        <div");
            BeginWriteAttribute("class", " class=\"", 280, "\"", 288, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            T??n ????ng nh???p:<span style=\"color:red\">*</span>&nbsp;\r\n            <input name=\"UserName\" placeholder=\"T??n ????ng nh???p\" class=\"form-control\" />\r\n        </div>\r\n        <div");
            BeginWriteAttribute("class", " class=\"", 474, "\"", 482, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            Password:<span style=""color:red"">*</span>&nbsp;
            <input type=""password"" name=""Password"" placeholder=""M???t kh???u"" class=""form-control"" />
        </div>
        <div style=""text-align:right; margin:10px;"">
            <button type=""button"" class=""btn btn-primary btnLogin"">????ng nh???p</button>
");
            WriteLiteral("        </div>\r\n    </div>\r\n    <div class=\"container\" style=\"width: 500px;\">\r\n        <br /> <br />\r\n        <h2 class=\"text-center\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d442eb791642ef1b67d54edb40ae72e92280f645070", async() => {
                WriteLiteral("Back to Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h2>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            function Admin() {
                this.userName = ($('input[name=UserName]').val() || '');
                this.password = ($('input[name=Password]').val() || '');
            }
            var $danhmuc = {
                init: function () {
                    $danhmuc.LoginClick();
                },
                $thisPage: $('.card'),
                LoginClick: function () {
                    $danhmuc.$thisPage.find('.btnLogin').off('click').on('click', function () {
                        let item = new Admin();
                        if (item.userName == """" || item.password == """") {
                            $msgDialog.confirm(""orange"", null, ""Vui l??ng nh???p t??n ????ng nh???p v?? m???t kh???u"", null, null, null);
                        }
                        else {
                            var getResponse = AjaxConfig.sendRequestToServer(""/Account/CheckAccount"", ""Post"", item);
                            getRes");
                WriteLiteral(@"ponse.then(function (response) {
                                if (response.header.msgType == BoxType.Success) {
                                    window.location.href = '/Dashboard';
                                }
                                else {
                                    $msgDialog.confirm(response.header.msgType, null, response.description, null, null, null);
                                }
                            }).catch(function (xhr) {
                                AjaxConfig.CatchError(xhr);
                            });
                        }
                    })
                }
            };
            $danhmuc.init();
        });
    </script>
");
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
