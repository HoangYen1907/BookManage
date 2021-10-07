#pragma checksum "D:\VS_Net2\BookManage\BookManagement\Views\Book\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "662383c2c8251b01623f1e34065aa4086b5c665f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Index), @"mvc.1.0.view", @"/Views/Book/Index.cshtml")]
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
#line 1 "D:\VS_Net2\BookManage\BookManagement\Views\Book\Index.cshtml"
using BookManagement.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VS_Net2\BookManage\BookManagement\Views\Book\Index.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"662383c2c8251b01623f1e34065aa4086b5c665f", @"/Views/Book/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a3096475496e018f050ad657f055d832dbd214d", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "10", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "20", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "50", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "100", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\VS_Net2\BookManage\BookManagement\Views\Book\Index.cshtml"
  
    BookManagementDbContext db = _context;
    List<Category> lstCategory = db.Categories.ToList();
    Layout = "_LayoutManage";
    ViewBag.Title = "";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card"">
    <div class=""card-header"">
        <div class=""float-left"">
            <button type=""button"" class=""btn btn-primary btnAddNew"" data-toggle=""modal"" data-target=""#CreateOrUpdateModal""><i class=""fa fa-plus"">&nbsp;Thêm mới</i></button>
        </div>
        <div class=""float-right frame-header"">
            <input placeholder=""Tìm kiếm ..."" name=""Keyword"" />
            <button type=""button"" class=""btn btn-primary btnSearch""><i class=""fa fa-search"">&nbsp;Tìm kiếm</i></button>
        </div>
    </div>
    <div class=""card-body"">
        <div class=""row"">
            <div class=""col-10"" style=""display:none"">
                Số bản ghi/trang:&nbsp;
                <select name=""ValuePage"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "662383c2c8251b01623f1e34065aa4086b5c665f6362", async() => {
                WriteLiteral("10");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "662383c2c8251b01623f1e34065aa4086b5c665f7537", async() => {
                WriteLiteral("20");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "662383c2c8251b01623f1e34065aa4086b5c665f8712", async() => {
                WriteLiteral("30");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "662383c2c8251b01623f1e34065aa4086b5c665f9887", async() => {
                WriteLiteral("40");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </select>\r\n            </div>\r\n            <div class=\"col-2 text-right\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "662383c2c8251b01623f1e34065aa4086b5c665f11157", async() => {
                WriteLiteral("Quay lại danh sách");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div");
            BeginWriteAttribute("class", " class=\"", 1442, "\"", 1450, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""width:100%; margin-top:10px;"">
            <table id=""TBLDANHSACH"" class=""table table-bordered table-sm"">
                <thead class=""thead-light"">
                    <tr>
                        <th class=""text-center"" style=""width:50px;"">STT</th>
                        <th class=""text-center"" style=""width:180px;"">Tên sách</th>
                        <th class=""text-center"" style=""width:160px;"">Tác giả</th>
                        <th class=""text-center"" style=""width:360px;"">Mô tả</th>
                        <th class=""text-center""></th>
                    </tr>
                </thead>
                <tbody>
                </tbody>
            </table>
        </div>
    </div>
</div>

<div class=""modal"" data-backdrop=""static"" id=""CreateOrUpdateModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog  modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
     ");
            WriteLiteral(@"           <h4 class=""modal-title inline-block"" id=""exampleModalLabel""><i class='fa fa-list-alt' aria-hidden='true'></i>&nbsp;Cập nhật thông tin sách</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-content"" style=""border:none; margin: 10px auto;"">
                <input name=""BookId"" class=""hide"" style=""display:none"" />
                <div");
            BeginWriteAttribute("class", " class=\"", 3009, "\"", 3017, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""col-md-3""><span>Tên sách:<span style=""color:red"">*</span>&nbsp;</span></div>
                    <div class=""col-md-12""><input name=""BookName"" placeholder=""Tên sách"" class=""form-control"" /></div>
                </div>
                <div");
            BeginWriteAttribute("class", " class=\"", 3295, "\"", 3303, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"col-md-3\"><span>Tác giả:&nbsp;</span></div>\r\n                    <div class=\"col-md-12\"><input name=\"Author\" placeholder=\"Tác giả\" class=\"form-control\" /></div>\r\n                </div>\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 3545, "\"", 3553, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""col-md-3""><span>Số chương:&nbsp;</span></div>
                    <div class=""col-md-12""><input type=""number"" name=""TotalChapter"" placeholder=""Số chương"" class=""form-control"" /></div>
                </div>
                <div");
            BeginWriteAttribute("class", " class=\"", 3819, "\"", 3827, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"col-md-3\"><span>Thể loại:&nbsp;</span></div>\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 3933, "\"", 3941, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"display:flex; font-size:14px; flex-wrap:wrap;\">\r\n");
#nullable restore
#line 80 "D:\VS_Net2\BookManage\BookManagement\Views\Book\Index.cshtml"
                         foreach (var item in lstCategory)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-md-3\">\r\n                                <input type=\"checkbox\" data-id=\"");
#nullable restore
#line 83 "D:\VS_Net2\BookManage\BookManagement\Views\Book\Index.cshtml"
                                                           Write(item.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"category\"");
            BeginWriteAttribute("name", " name=\"", 4236, "\"", 4272, 1);
#nullable restore
#line 83 "D:\VS_Net2\BookManage\BookManagement\Views\Book\Index.cshtml"
WriteAttributeValue("", 4243, "Category"+item.CategoryId, 4243, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 4273, "\"", 4307, 1);
#nullable restore
#line 83 "D:\VS_Net2\BookManage\BookManagement\Views\Book\Index.cshtml"
WriteAttributeValue("", 4278, "Category"+item.CategoryId, 4278, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                <label");
            BeginWriteAttribute("for", " for=\"", 4351, "\"", 4386, 1);
#nullable restore
#line 84 "D:\VS_Net2\BookManage\BookManagement\Views\Book\Index.cshtml"
WriteAttributeValue("", 4357, "Category"+item.CategoryId, 4357, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"cursor:pointer\">");
#nullable restore
#line 84 "D:\VS_Net2\BookManage\BookManagement\Views\Book\Index.cshtml"
                                                                                             Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                            </div>\r\n");
#nullable restore
#line 86 "D:\VS_Net2\BookManage\BookManagement\Views\Book\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 4574, "\"", 4582, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""col-md-3""><span>Hình ảnh:&nbsp;</span></div>
                    <div class=""col-md-3""><input type=""file"" name=""BookImage"" placeholder=""Hình ảnh"" class=""form-control-file"" accept=""image/*""/></div>
                    <div>
                        <img src=""#""");
            BeginWriteAttribute("alt", " alt=\"", 4880, "\"", 4886, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    </div>\r\n                </div>\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 4964, "\"", 4972, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""col-sm-3""><span>Mô tả:&nbsp;</span></div>
                    <div class=""col-sm-12"">
                        <textarea class=""form-control"" name=""Description"" placeholder=""Mô tả"" rows=""4""></textarea>
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-primary btnSave"">Lưu lại</button>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Đóng</button>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $modal = $('#CreateOrUpdateModal');
        $(document).ready(function () { //Sau khi load xong html
            function LoadContentSearch(pageNum) {
                this.Keyword = $('input[name=Keyword]').val(); //Lấy giá trị của ô input[name=Keyword] : giá trị tìm kiếm
                this.ValuePage = $('select[name=ValuePage]').val(); //Lấy giá trị của ô select[name=ValuePage] : số bản ghi trong 1 trang
                this.PageNum = pageNum //trang số
            }

            function GetListCate() {
                let lstCate = [];
                $modal.find("".category[type=checkbox]:checked"").each(function () {
                    let id = $(this).data('id');
                    if (id > 0) {
                        lstCate.push(id);
                    }
                })
                return lstCate;
            }

            function Book() {
                this.bookId = ($('input[name=BookId]').val() || 0);
                this.bookName = $('inp");
                WriteLiteral(@"ut[name=BookName]').val();
                this.author = $('input[name=Author]').val();
                this.totalChapter = $('input[name=TotalChapter]').val();
                //image
                //this.image = """";
                this.description = $('[name=Description]').val();
                //category
            }
            var $danhmuc = {
                init: function () {
                    $danhmuc.LoadDanhSach(1);
                    $danhmuc.SearchClick();
                },
                $thisPage: $('.card'),
                SearchClick: function () {
                    $danhmuc.$thisPage.find('.btnSearch').off('click').on('click', function () { $danhmuc.LoadDanhSach(1); }); //Sự kiện khi click vào nút có class btnSearch
                },
                LoadDanhSach: function (pageNum) {
                    var dataSend = new LoadContentSearch(pageNum);
                    var getResponse = AjaxConfig.sendRequestToServer(""/Book/GetList"", ""GET"", dataSend); //Gọi v");
                WriteLiteral(@"ào controller Category, hàm Getlist, truyền vào DataSend
                    getResponse.then(function (response) { //getResponse thực hiện xong thì thực hiện funtion với tham số truyền vào là response - kết quả trả về của AjaxConfig.sendRequestToServer(""/Category/GetList"", ""GET"", dataSend);
                        //console.log(response);
                        if (response.header.msgType == BoxType.Success) {
                            $danhmuc.PageCurrent = pageNum;
                            var htmlContent = """";
                            response.data = response.data || [];
                            if (response.data.length == 0) {
                                htmlContent = '<tr><td colspan=""10"" class=""text-center"">Không có dữ liệu.</td></tr>';
                                $danhmuc.$thisPage.find('table#TBLDANHSACH tbody').html(htmlContent);
                                $('.countItem').text(response.data.length);
                                $('.pagination-page').html('');
");
                WriteLiteral(@"                                return false;
                            }
                            for (var i = 0; i < response.data.length; i++) {
                                var $Item = response.data[i];
                                htmlContent += '<tr>' +
                                    '<td class=""text-center"">' + (i + 1) + '</td>' +
                                    '<td class=""text-center"">' + ($Item.bookName || '') + '</td>' +
                                    '<td class=""text-center"">' + ($Item.author || '') + '</td>' +
                                    '<td class=""text-center"">' + ($Item.description || '') + '</td>' +
                                    '<td class=""text-center"">' +
                                        '<button type=""button"" class=""btn btn-secondary btn-sm btnEdit"" style=""margin-right: 5px;"" data-id=""' + $Item.bookId + '""><i class=""fa fa-pencil-square-o"">&nbsp;Sửa</i></button>' +
                                        '<button type=""button"" class=""");
                WriteLiteral(@"btn btn-danger btn-sm btnDelete"" data-id=""' + $Item.bookId + '""><i class=""fa fa-trash-o"">&nbsp;Xóa</i></button>' +
                                    '</td >' +
                                    '</tr>';
                            }
                            htmlContent = $ValidateXSS.sanitizeHtmlTable([htmlContent]);
                            $danhmuc.$thisPage.find('table#TBLDANHSACH tbody').html(htmlContent);
                            $('.countItem').text(response.data.length);
                            $danhmuc.DeleteClick();
                            $danhmuc.EditClick();
                            /*LoadPaginationPage($danhmuc.$thisPage, $danhmuc.LoadDanhSach, response.Body.TotalRowData, response.Body.Data.length, pageNum, valuePage || 100);*/
                        } else {
                            $msgDialog.confirm(response.header.msgType, null, response.body.description, null, null, null);
                        }
                    }).catch(function (xhr) {
      ");
                WriteLiteral(@"                  AjaxConfig.CatchError(xhr);
                    });
                },
                EditClick: function () {
                    $('.btnEdit').off('click').on('click', function () {
                        let id = $(this).data('id');
                        if (id > 0) {
                            let dataSend = { ""id"": id };
                            var getResponse = AjaxConfig.sendRequestToServer(""Book/GetBook"", ""GET"", dataSend);
                            getResponse.then(function (response) {
                                if (response.header.msgType == BoxType.Success) {
                                    let item = response.data;
                                    let lstCate = item.lstCate;
                                    $('input[name=BookId]').val(item.bookId);
                                    $('input[name=BookName]').val(item.bookName);
                                    $('input[name=Author]').val(item.author);
                                 ");
                WriteLiteral(@"   $('input[name=TotalChapter]').val(item.totalChapter);
                                    //image
                                    
                                    $('[name=Description]').val(item.description);
                                    //category
                                    for (let cateId of lstCate) {
                                        let name = ""Category"" + cateId;
                                        $modal.find(`input[name=${name}]`).prop('checked', true);
                                        /*$modal.find('input[name='+name+']').prop('checked', true);*/
                                    }
                                    $modal.modal('show');
                                }
                                else {
                                    alert(""Thông tin yêu cầu không hợp lệ"");
                                }
                            }).catch(function (xhr) {
                                AjaxConfig.CatchError(xhr);
      ");
                WriteLiteral(@"                      });
                        }
                    })
                },
                DeleteClick: function () {
                    $('.btnDelete').off('click').on('click', function () {
                        let id = $(this).data('id');
                        if (id > 0) {
                            $.confirm({
                                title: 'XÁC NHẬN THÔNG TIN',
                                content: ""Bạn có chắc chắn muốn xóa không?"",
                                type: 'orange',
                                typeAnimated: true,
                                columnClass: 'col-md-6 col-md-offset-0',
                                container: $('.card'),
                                buttons: {
                                    OK: {
                                        text: '<i class=""fa fa-trash""></i>&nbsp;Xóa',
                                        btnClass: ""btn-primary"",
                                        action: function () ");
                WriteLiteral(@"{
                                            let _self = this;
                                            let dataSend = { ""id"": id }; // lấy được id của Category
                                            var getResponse = AjaxConfig.sendRequestToServer(""Book/Delete"", ""GET"", dataSend);
                                            getResponse.then(function (response) {
                                                if (response.header.msgType == BoxType.Success) {
                                                    $danhmuc.LoadDanhSach(1);
                                                    $msgDialog.confirm(response.header.msgType, null, response.description, null, null, null);
                                                }
                                                else {
                                                    $msgDialog.confirm(response.header.msgType, null, response.description, null, null, null);
                                                }
                     ");
                WriteLiteral(@"                       }).catch(function (xhr) {
                                                AjaxConfig.CatchError(xhr);
                                            });
                                        }
                                    },
                                    close: {
                                        text: '<i class=""fa fa-close""></i>&nbsp;Đóng',
                                        action: function () {
                                        }
                                    }
                                }
                            });
                        }
                    })
                }
            };
            $danhmuc.init();

            var $updateModal = {
                init: function () {
                    $updateModal.OpenModal();
                    $updateModal.CloseModal();
                    $updateModal.CreateOrUpdate();
                    $updateModal.FileChange();
                },
              ");
                WriteLiteral(@"  OpenModal: function () {
                    $modal.on('shown.bs.modal', function () {
                        let id = ($modal.find('input[name=BookId]').val() || 0);
                        if (id == 0) {
                            $updateModal.ResetModal();
                        }
                    })
                },
                CloseModal: function () {
                    $modal.on('hidden.bs.modal', function () {
                        $updateModal.ResetModal();
                    })
                },
                ResetModal: function () {
                    $modal.find('input').not('[type=checkbox]').val("""");
                    $modal.find('input[type=checkbox]').prop('checked', false);
                    $modal.find('textarea').val("""");
                },
                LoadDataSend: function () {
                    let dataForm = new FormData();
                    let item = new Book();
                    if (item.BookName == """") {
                    ");
                WriteLiteral(@"    alert(""Vui lòng nhập tên sách"");
                        return false;
                    };
                    dataForm.append('generalInfo', JSON.stringify(item));
                    let $file = $modal.find('input[type=file]');
                    let file = $file[0].files[0];
                    dataForm.append('file', file);
                    let lstCate = GetListCate();
                    dataForm.append('lstCate', JSON.stringify(lstCate));
                    return dataForm;
                },
                CreateOrUpdate: function () {
                    $modal.find('.btnSave').off('click').on('click', function () {
                        let dataSend = $updateModal.LoadDataSend();
                        if (dataSend) {
                            let id = ($('input[name=BookId]').val() || 0);
                            let url = (id == 0 || id == """") ? ""/Book/AddNew"" : ""/Book/Update"";
                            var getResponse = AjaxConfig.sendRequestFileToServer(url");
                WriteLiteral(@", ""Post"", dataSend);
                            getResponse.then(function (response) {
                                if (response.header.msgType == BoxType.Success) {
                                    $danhmuc.LoadDanhSach(1);
                                    $('#CreateOrUpdateModal').modal('hide');
                                    $msgDialog.confirm(response.header.msgType, null, response.description, null, null, null);
                                }
                                else {
                                    $msgDialog.confirm(response.header.msgType, null, response.description, null, null, null);
                                }
                            }).catch(function (xhr) {
                                AjaxConfig.CatchError(xhr);
                            });
                        }
                    })
                },
                FileChange: function () {
                    $modal.find('input[type=file]').on('change', function () {
 ");
                WriteLiteral(@"                       var file = $(this)[0].files[0]
                        if (file) {
                            if (file.size > 2 * 1024 * 1024) {
                                $msgDialog.confirm(""orange"", null, ""Ảnh tải lên không vượt quá 2MB"", null, null, null);
                                $(this).val('').trigger('change');
                                return false;
                            }
                        }
                    })
                }
            };
            $updateModal.init();
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