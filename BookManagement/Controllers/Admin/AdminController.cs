using BookManagement.Common;
using BookManagement.Data;
using BookManagement.Dto;
using BookManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Controllers.Admin
{
    public class AdminController : Controller
    {
        private readonly BookManagementDbContext _db;
        public AdminController(BookManagementDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetAdmin(int id = 0)
        {
            Message msg = new Message();
            try
            {
                msg.Header.MsgType = MessageType.ClientError;
                BookManagement.Models.Admin result = _db.Admins.Where(x => x.UserID == id).FirstOrDefault();
                if (result == null)
                {
                    msg.Description = "Yêu cầu không hợp lệ";
                    return Json(msg);
                }
                msg.Data = new { result.UserID, result.UserName, result.Email, result.Password };
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
                var result = _db.Admins.Where(x=>x.UserName.Contains(keyword));

                msg.TotalRowData = result.Count();
                //Skip(n): Bỏ qua n bản ghi tìm được sau khi sắp xếp;
                //Take(n): Lấy n bản ghi sau khi sắp xếp
                result = result.OrderBy(x => x.UserName);
                msg.Data = result.Select(x => new { x.UserID, x.UserName, x.Email, x.IsActive }).ToList();
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

        private Message CheckValid(BookManagement.Models.Admin Item)
        {
            Message msg = new Message();
            msg.Header.MsgType = MessageType.ClientError;
            if (string.IsNullOrEmpty(Item.UserName) || string.IsNullOrEmpty(Item.Password))
            {
                msg.Description = "Vui lòng nhập tên đăng nhập và mật khẩu";
                msg.Data = "UserName";
                return msg;
            }
            var Exsits = _db.Admins.Where(x => x.UserID != Item.UserID && x.UserName.ToLower().Trim() == Item.UserName.ToLower().Trim()).FirstOrDefault();
            if (Exsits != null)
            {
                msg.Description = "Tên đăng nhập đã tồn tại, vui lòng nhập lại";
                msg.Data = "UserName";
                return msg;
            }
            Exsits = _db.Admins.Where(x => x.UserID != Item.UserID && x.Email.Trim() == Item.Email.Trim()).FirstOrDefault();
            if (Exsits != null)
            {
                msg.Description = "Email đã tồn tại, vui lòng nhập lại";
                msg.Data = "Email";
                return msg;
            }
            msg.Header.MsgType = MessageType.Success;
            return msg;
        }
        public JsonResult AddNew(BookManagement.Models.Admin Item)
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
                PashwordHash hash = new PashwordHash();
                Item.Password = hash.PasswordHash(Item.Password);
                Item.CreateTime = DateTime.Now;
                Item.IsActive = false;
                _db.Admins.Add(Item);
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

        public JsonResult Update(BookManagement.Models.Admin Item)
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

                BookManagement.Models.Admin Exsits = _db.Admins.Where(x => x.UserID == Item.UserID).FirstOrDefault();
                if (Exsits == null)
                {
                    msg.Description = "Thông tin yêu cầu không hợp lệ";
                    return Json(msg);
                }

                Item.ModifyTime = DateTime.Now;
                Item.IsActive = Exsits.IsActive;
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

                BookManagement.Models.Admin Exsits = _db.Admins.Where(x => x.UserID == id).FirstOrDefault();
                if (Exsits == null)
                {
                    msg.Description = "Thông tin yêu cầu không hợp lệ";
                    return Json(msg);
                }

                _db.Admins.Remove(Exsits);
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

        public JsonResult Confirm(int id = 0)
        {
            Message msg = new Message();
            try
            {
                msg.Header.MsgType = MessageType.ClientError;
                BookManagement.Models.Admin Exsits = _db.Admins.Where(x => x.UserID == id).FirstOrDefault();
                if (Exsits == null)
                {
                    msg.Description = "Thông tin yêu cầu không hợp lệ";
                    return Json(msg);
                }

                BookManagement.Models.Admin Item = Exsits;
                Item.IsActive = true;
                Item.ModifyTime = DateTime.Now;
                _db.Entry(Exsits).State = EntityState.Detached;
                _db.Entry(Item).State = EntityState.Modified;
                _db.SaveChanges();
                msg.Description = "Kích hoạt thành công";
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
