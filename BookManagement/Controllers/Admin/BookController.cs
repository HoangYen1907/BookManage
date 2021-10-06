using BookManagement.Common;
using BookManagement.Data;
using BookManagement.Dto;
using BookManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
                //BookCategory category = _db.BookCategories.Where(x => x.BookId == id).FirstOrDefault();
                msg.Data = new { result.BookId, result.BookName, result.Author, result.BookImage, result.Description };
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
        public JsonResult AddNew(Book Item)
        {
            Message msg = new Message();
            try
            {
                msg.Header.MsgType = MessageType.ClientError;
                Message checkValid = CheckValid(Item);
                if (checkValid.Header.MsgType == MessageType.ClientError)
                {
                    return Json(checkValid);
                }

                Item.CreateTime = DateTime.Now;
                _db.Books.Add(Item);
                _db.SaveChanges();

                //BookCategory category = _db.BookCategories.Where(x => x.BookId == Item.BookId).FirstOrDefault();

                msg.Description = "Thêm mới thành công";
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

        public JsonResult Update(Book Item)
        {
            Message msg = new Message();
            try
            {
                msg.Header.MsgType = MessageType.ClientError;
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

                Item.ModifyTime = DateTime.Now;
                _db.Entry(Exsits).State = EntityState.Detached;
                _db.Entry(Item).State = EntityState.Modified;
                _db.SaveChanges();

                //BookCategory category = _db.BookCategories.Where(x => x.BookId == Item.BookId).FirstOrDefault();

                msg.Description = "Sửa thành công";
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
