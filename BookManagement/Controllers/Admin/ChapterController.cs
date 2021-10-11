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
    public class ChapterController : Controller
    {
        private readonly BookManagementDbContext _db;
        public ChapterController(BookManagementDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetChapter(int id = 0)
        {
            Message msg = new Message();
            try
            {
                msg.Header.MsgType = MessageType.ClientError;
                Chapter result = _db.Chapters.Where(x => x.ChapterId == id).FirstOrDefault();
                if (result == null)
                {
                    msg.Description = "Yêu cầu không hợp lệ";
                    return Json(msg);
                }
                msg.Data = new { result.ChapterId, result.BookId, result.ChapterName, result.Content };
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
        public JsonResult GetList(int bookId = 0)
        {
            Message msg = new Message();
            try
            {
                msg.Header.MsgType = MessageType.ClientError;
                //var keyword = string.IsNullOrEmpty(Item.Keyword) ? "" : Item.Keyword.Trim();
                //var result = _db.Chapters.Where(x => x.ChapterName.Contains(keyword));

                var result = _db.Chapters.Where(x => x.BookId == bookId).OrderBy(x=>x.ChapterId);

                msg.TotalRowData = result.Count();
                //Skip(n): Bỏ qua n bản ghi tìm được sau khi sắp xếp;
                //Take(n): Lấy n bản ghi sau khi sắp xếp
                msg.Data = result.Select(x => new { x.ChapterId, x.TotalView, x.ChapterName }).ToList();
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

        private Message CheckValid(Chapter Item)
        {
            Message msg = new Message();
            msg.Header.MsgType = MessageType.ClientError;

            var Exsits = _db.Chapters.Where(x => x.ChapterId != Item.ChapterId && x.ChapterName.ToLower().Trim() == Item.ChapterName.ToLower().Trim() && x.BookId == Item.BookId).FirstOrDefault();
            if (Exsits != null && string.IsNullOrEmpty(Item.ChapterName) == false)
            {
                msg.Description = "Chương này đã tồn tại, vui lòng nhập lại";
                msg.Data = "ChapterName";
                return msg;
            }
            msg.Header.MsgType = MessageType.Success;
            return msg;
        }

        public JsonResult AddNew(Chapter Item)
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
                Item.TotalView = 0;
                Item.CreateTime = DateTime.Now;
                _db.Chapters.Add(Item);
                _db.SaveChanges();
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

        public JsonResult Update(Chapter Item)
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

                Chapter Exsits = _db.Chapters.Where(x => x.ChapterId == Item.ChapterId).FirstOrDefault();
                if (Exsits == null)
                {
                    msg.Description = "Thông tin yêu cầu không hợp lệ";
                    return Json(msg);
                }

                Item.ModifyTime = DateTime.Now;
                _db.Entry(Exsits).State = EntityState.Detached;
                _db.Entry(Item).State = EntityState.Modified;
                _db.SaveChanges();
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

                Chapter Exsits = _db.Chapters.Where(x => x.ChapterId == id).FirstOrDefault();
                if (Exsits == null)
                {
                    msg.Description = "Thông tin yêu cầu không hợp lệ";
                    return Json(msg);
                }

                _db.Chapters.Remove(Exsits);
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
