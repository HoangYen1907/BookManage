using BookManagement.Common;
using BookManagement.Data;
using BookManagement.Dto;
using BookManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nancy.Json;

namespace BookManagement.Controllers.Admin
{
    public class BookController : Controller
    {
        private readonly BookManagementDbContext _db;
        public BookController(BookManagementDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetBook(int id = 0)
        {
            Message msg = new Message();
            try
            {
                msg.Header.MsgType = MessageType.ClientError;
                Book result = _db.Books.Where(x => x.BookId == id).FirstOrDefault();
                if (result == null)
                {
                    msg.Description = "Yêu cầu không hợp lệ";
                    return Json(msg);
                }
                List<int> lstCategory = _db.BookCategories.Where(x => x.BookId == id).Select(x=>x.CategoryId).ToList();
                msg.Data = new { result.BookId, result.BookName, result.Author, result.BookImage, result.Description, LstCate = lstCategory};
                msg.Header.MsgType = MessageType.Success;
                return Json(msg);
            }
            catch (Exception ex)
            {
                msg.Header.MsgType = MessageType.ServerError;
                msg.Description = ex.Message;
                return Json(msg);
            }
        }

        [HttpGet]
        public JsonResult GetList(SearchDto Item)
        {
            Message msg = new Message();
            try
            {
                msg.Header.MsgType = MessageType.ClientError;
                var keyword = string.IsNullOrEmpty(Item.Keyword) ? "" : Item.Keyword.Trim();
                var result = _db.Books.Where(x => x.BookName.Contains(keyword));

                msg.TotalRowData = result.Count();
                //Skip(n): Bỏ qua n bản ghi tìm được sau khi sắp xếp;
                //Take(n): Lấy n bản ghi sau khi sắp xếp
                result = result.OrderBy(x => x.BookName);
                msg.Data = result.Select(x => new { x.BookId, x.BookName, x.Author, x.Description }).ToList();
                msg.Header.MsgType = MessageType.Success;
                return Json(msg);
            }
            catch (Exception ex)
            {
                msg.Header.MsgType = MessageType.ServerError;
                msg.Description = ex.Message;
                return Json(msg);
            }
        }

        private Message CheckValid(Book Item)
        {
            Message msg = new Message();
            msg.Header.MsgType = MessageType.ClientError;
            if (string.IsNullOrEmpty(Item.BookName))
            {
                msg.Description = "Vui lòng nhập tên sách";
                msg.Data = "BookName";
                return msg;
            }
            var Exsits = _db.Books.Where(x => x.BookId != Item.BookId && x.BookName.ToLower().Trim() == Item.BookName.ToLower().Trim()).FirstOrDefault();
            if (Exsits != null)
            {
                msg.Description = "Sách đã tồn tại, vui lòng nhập lại";
                msg.Data = "BookName";
                return msg;
            }
            msg.Header.MsgType = MessageType.Success;
            return msg;
        }
        public JsonResult AddNew()
        {
            using (var trans = _db.Database.BeginTransaction())
            {
                Message msg = new Message();
                try
                {
                    msg.Header.MsgType = MessageType.ClientError;

                    var generalInfo = HttpContext.Request.Form["generalInfo"];
                    var listBookCate = HttpContext.Request.Form["lstCate"];
                    var file = HttpContext.Request.Form.Files.Count > 0 ? HttpContext.Request.Form.Files[0] : null;
                    if (string.IsNullOrEmpty(generalInfo))
                    {
                        msg.Description = "Thông tin yêu cầu không hợp lệ";
                        return Json(msg);
                    }
                    var Item = new JavaScriptSerializer().Deserialize<Book>(generalInfo);
                    var lstCate = new JavaScriptSerializer().Deserialize<List<int>>(listBookCate);
                    Message checkValid = CheckValid(Item);
                    if (checkValid.Header.MsgType == MessageType.ClientError)
                    {
                        return Json(checkValid);
                    }
                    Item.CreateTime = DateTime.Now;
                    _db.Books.Add(Item);
                    _db.SaveChanges();
                    IEnumerable<BookCategory> lstBookCateIn = lstCate.Select(x => new BookCategory() { CategoryId = x, BookId = Item.BookId });
                    if (lstBookCateIn.Any())
                    {
                        _db.BookCategories.AddRange(lstBookCateIn);
                        _db.SaveChanges();
                    }

                    trans.Commit();
                    msg.Description = "Thêm mới thành công";
                    msg.Header.MsgType = MessageType.Success;
                    return Json(msg);
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    msg.Header.MsgType = MessageType.ServerError;
                    msg.Description = ex.Message;
                    return Json(msg);
                } 
            }
        }

        public JsonResult Update()
        {
            using (var trans = _db.Database.BeginTransaction())
            {
                Message msg = new Message();
                try
                {
                    msg.Header.MsgType = MessageType.ClientError;

                    var generalInfo = HttpContext.Request.Form["generalInfo"];
                    var listBookCate = HttpContext.Request.Form["lstCate"];
                    var file = HttpContext.Request.Form.Files.Count > 0 ? HttpContext.Request.Form.Files[0] : null;

                    if (string.IsNullOrEmpty(generalInfo))
                    {
                        msg.Description = "Thông tin yêu cầu không hợp lệ";
                        return Json(msg);
                    }
                    var Item = new JavaScriptSerializer().Deserialize<Book>(generalInfo);

                    Message checkValid = CheckValid(Item);
                    if (checkValid.Header.MsgType == MessageType.ClientError)
                    {
                        return Json(checkValid);
                    }

                    Book Exsits = _db.Books.Where(x => x.BookId == Item.BookId).FirstOrDefault();
                    if (Exsits == null)
                    {
                        msg.Description = "Thông tin yêu cầu không hợp lệ";
                        return Json(msg);
                    }

                    var lstCate = new JavaScriptSerializer().Deserialize<List<int>>(listBookCate);

                    Item.ModifyTime = DateTime.Now;
                    _db.Entry(Exsits).State = EntityState.Detached;
                    _db.Entry(Item).State = EntityState.Modified;
                    _db.SaveChanges();

                    List<int> lstExsits = _db.BookCategories.Where(x => lstCate.Contains(x.CategoryId) == true && x.BookId == Item.BookId).Select(x=>x.CategoryId).ToList();
                    List<BookCategory> lstRemove = _db.BookCategories.Where(x => lstCate.Contains(x.CategoryId) == false && x.BookId == Item.BookId).ToList();
                    _db.BookCategories.RemoveRange(lstRemove);
                    _db.SaveChanges();

                    IEnumerable<BookCategory> lstBookCateIn = lstCate.Where(x=> lstExsits.Contains(x) == false).Select(x => new BookCategory() { CategoryId = x, BookId = Item.BookId });
                    if (lstBookCateIn.Any())
                    {
                        _db.BookCategories.AddRange(lstBookCateIn);
                        _db.SaveChanges();
                    }

                    trans.Commit();
                    msg.Description = "Sửa thành công";
                    msg.Header.MsgType = MessageType.Success;
                    return Json(msg);
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    msg.Header.MsgType = MessageType.ServerError;
                    msg.Description = ex.Message;
                    return Json(msg);
                } 
            }
        }

        public JsonResult Delete(int id = 0)
        {
            Message msg = new Message();
            try
            {
                msg.Header.MsgType = MessageType.ClientError;

                Book Exsits = _db.Books.Where(x => x.BookId == id).FirstOrDefault();
                if (Exsits == null)
                {
                    msg.Description = "Thông tin yêu cầu không hợp lệ";
                    return Json(msg);
                }

                _db.Books.Remove(Exsits);
                _db.SaveChanges();
                msg.Description = "Xóa thành công";
                msg.Header.MsgType = MessageType.Success;
                return Json(msg);
            }
            catch (Exception ex)
            {
                msg.Header.MsgType = MessageType.ServerError;
                msg.Description = ex.Message;
                return Json(msg);
            }
        }
    }
}
