#pragma checksum "D:\VS_Net2\BookManage\BookManagement\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef7c4f0afe3782914732a55192841516cacd667b"
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
#nullable restore
#line 1 "D:\VS_Net2\BookManage\BookManagement\Views\Home\Index.cshtml"
using BookManagement.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VS_Net2\BookManage\BookManagement\Views\Home\Index.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef7c4f0afe3782914732a55192841516cacd667b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a3096475496e018f050ad657f055d832dbd214d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/home/stylehome.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\VS_Net2\BookManage\BookManagement\Views\Home\Index.cshtml"
  
    //BookManagementDbContext db = _context;
    //List<Book> booknew = db.Books.OrderBy(x => x.ModifyTime).Take(5).ToList();
    //List<Book> bookcompleted = db.Books.Where(x => x.IsCompleted == true).Take(5).ToList();

    Layout = "_Layout";
    ViewData["Title"] = "Trang chủ";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef7c4f0afe3782914732a55192841516cacd667b4781", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ef7c4f0afe3782914732a55192841516cacd667b5043", async() => {
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
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef7c4f0afe3782914732a55192841516cacd667b6925", async() => {
                WriteLiteral(@"
    <div class=""container"">
        <h3>Sách mới cập nhật</h3>
        <div class=""book-new"">

        </div>
        
        <br /> <br />
        <h3>Sách đã hoàn thành</h3>
        <div class=""book-completed"">

        </div>
        
        <br />
    </div>
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
            WriteLiteral("\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () { //Sau khi load xong html
            var $danhmuc = {
                init: function () {
                    $danhmuc.LoadDanhSach();
                    $danhmuc.SearchClick();
                },
                SearchClick: function () {
                    $('.btnSearch').off('click').on('click', function () {
                        $danhmuc.LoadDanhSach();
                    });
                },
                LoadDanhSach: function () {
                    var keyword = ($('input[name=Keyword]').val() || """");
                    var dataSend = { 'keyword': keyword }
                    var getResponse = AjaxConfig.sendRequestToServer(""/Home/TimKiem"", ""GET"", dataSend);
                    getResponse.then(function (response) {
                        console.log(response);
                        if (response.header.msgType == BoxType.Success) {
                            var bookNewContent = """";
                            ");
                WriteLiteral(@"var bookCompletedContent = """";
                            var lstBookNew = response.data || [];
                            var lstBookCompleted = response.subData || [];
                            if (lstBookNew.length == 0) {
                                bookNewContent = '<hr /><p>Tạm thời chưa có sách. Vui lòng quay lại sau</p>';
                            }
                            else {
                                for (var i = 0; i < lstBookNew.length; i++) {
                                    let $Item = lstBookNew[i];
                                    bookNewContent += '<hr /><div>' +
                                        '<a class=""nav-link text-dark bookhome"" asp-controller=""Home"" asp-action=""NDSach"" asp-route-id=""' + $Item.bookId + '"" style=""display:flex;flex-wrap:wrap;cursor:pointer;"">' +
                                        '<div><img src=""' + $Item.bookImage + '"" /></div>' +
                                        '<div style=""margin-left:10px;margin-top:15px;""><");
                WriteLiteral(@"h4>' + $Item.bookName + '</h4>' +
                                        '<p><b>Tác giả:&nbsp;</b>' + $Item.author + '</p>' +
                                        '<p><b>Số chương:&nbsp;</b>' + $Item.totalChapter + '</p></div></a></div>'
                                }
                            }
                            if (lstBookCompleted.length == 0) {
                                bookCompletedContent = '<hr /><p>Tạm thời chưa có sách. Vui lòng quay lại sau</p>';
                            }
                            else {
                                for (var j = 0; j < lstBookCompleted.length; j++) {
                                    let $Item = lstBookCompleted[j];
                                    bookCompletedContent += '<hr /><div>' +
                                        '<a class=""nav-link text-dark bookhome"" asp-controller=""Home"" asp-action=""NDSach"" asp-route-id=""' + $Item.bookId + '"" style=""display:flex;flex-wrap:wrap;cursor:pointer;"">' +
                 ");
                WriteLiteral(@"                       '<div><img src=""' + $Item.bookImage + '"" /></div>' +
                                        '<div style=""margin-left:10px;margin-top:15px;""><h4>' + $Item.bookName + '</h4>' +
                                        '<p><b>Tác giả:&nbsp;</b>' + $Item.author + '</p>' +
                                        '<p><b>Số chương:&nbsp;</b>' + $Item.totalChapter + '</p></div></a></div>'
                                }
                            }
                            //document.getElementById(""loader1"").style.display = ""none"";
                            //bookNewContent = $ValidateXSS.sanitizeHtmlTable([bookNewContent]);
                            //bookCompletedContent = $ValidateXSS.sanitizeHtmlTable([bookCompletedContent]);
                            $('.book-new').html(bookNewContent);
                            $('.book-completed').html(bookCompletedContent);
                            $danhmuc.Redirect();
                        } else {
                     ");
                WriteLiteral(@"       $msgDialog.confirm(response.header.msgType, null, response.body.description, null, null, null);
                        }
                    }).catch(function (xhr) {
                        AjaxConfig.CatchError(xhr);
                    });
                },
                Redirect: function () {
                    $('.book-new').find('a').off('click').on('click', function () {
                        let url = '/Home/NDSach/' + ($(this).attr('asp-route-id'));
                        window.location = url;
                    });
                    $('.book-completed').find('a').off('click').on('click', function () {
                        let url = '/Home/NDSach/' + ($(this).attr('asp-route-id'));
                        window.location = url;
                    });
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
        public BookManagementDbContext _context { get; private set; }
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
