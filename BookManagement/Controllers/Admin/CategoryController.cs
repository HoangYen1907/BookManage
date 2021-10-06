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
    public class CategoryController : Controller
    {
        private readonly BookManagementDbContext _db;
        public CategoryController(BookManagementDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetCategory(int id = 0)
        {
            Message msg = new Message();
            try
            {
                msg.Header.MsgType = MessageType.ClientError;
                Category result = _db.Categories.Where(x => x.CategoryId == id).FirstOrDefault();
                if(result == null)
                {
                    msg.Description = "Yêu cầu không hợp lệ";
                    return Json(msg);
                }
                msg.Data = new { result.CategoryId, result.CategoryName, result.Description};
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
                var result = _db.Categories.Where(x => x.CategoryName.Contains(keyword));

                msg.TotalRowData = result.Count();
                //Skip(n): Bỏ qua n bản ghi tìm được sau khi sắp xếp;
                //Take(n): Lấy n bản ghi sau khi sắp xếp
                result = result.OrderBy(x => x.CategoryName);
                msg.Data = result.Select(x=>new { x.CategoryId, x.CategoryName, x.Description}).ToList();
                msg.Header.MsgType = MessageType.Success;
                return Json(msg);
            }
            catch(Exception ex)
            {
                msg.Header.MsgType = MessageType.ServerError;
                msg.Description = ex.Message;
                return Json(msg);
            }
        }

        private Message CheckValid(Category Item)
        {
            Message msg = new Message();
            msg.Header.MsgType = MessageType.ClientError;
            if (string.IsNullOrEmpty(Item.CategoryName))
            {
                msg.Description = "Vui lòng nhập tên thể loại";
                msg.Data = "CategoryName";
                return msg;
            }
            var Exsits = _db.Categories.Where(x => x.CategoryId != Item.CategoryId && x.CategoryName.ToLower().Trim() == Item.CategoryName.ToLower().Trim()).FirstOrDefault();
            if(Exsits != null)
            {
                msg.Description = "Thể loại đã tồn tại, vui lòng nhập lại";
                msg.Data = "CategoryName";
                return msg;
            }
            msg.Header.MsgType = MessageType.Success;
            return msg;
        }
        public JsonResult AddNew(Category Item)
        {
            Message msg = new Message();
            try
            {
                msg.Header.MsgType = MessageType.ClientError;
                Message checkValid = CheckValid(Item);
                if(checkValid.Header.MsgType == MessageType.ClientError)
                {
                    return Json(checkValid);
                }

                Item.CreateTime = DateTime.Now;
                _db.Categories.Add(Item);
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

        public JsonResult Update(Category Item)
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

                Category Exsits = _db.Categories.Where(x => x.CategoryId == Item.CategoryId).FirstOrDefault();
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

                Category Exsits = _db.Categories.Where(x => x.CategoryId == id).FirstOrDefault();
                if (Exsits == null)
                {
                    msg.Description = "Thông tin yêu cầu không hợp lệ";
                    return Json(msg);
                }

                _db.Categories.Remove(Exsits);
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
