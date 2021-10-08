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

namespace BookManagement.Controllers
{
    public class AccountController : Controller
    {
        private readonly BookManagementDbContext _db;
        public AccountController(BookManagementDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CreateAccount()
        {
            return View();
        }

        public JsonResult CheckAccount(BookManagement.Models.Admin Item)
        {
            Message msg = new Message();
            try
            {
                msg.Header.MsgType = MessageType.ClientError;
                PashwordHash hash = new PashwordHash();
                string password = hash.PasswordHash(Item.Password);
                BookManagement.Models.Admin result = _db.Admins.Where(x => x.UserName == Item.UserName && x.Password == password).FirstOrDefault();
                if (result == null || result.IsActive == false)
                {
                    msg.Description = "Đăng nhập thất bại";
                    return Json(msg);
                }
                msg.Description = "Đăng nhập thành công";
                msg.Data = new { result.UserName, result.Password };
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
