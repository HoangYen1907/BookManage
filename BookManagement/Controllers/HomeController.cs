using BookManagement.Common;
using BookManagement.Data;
using BookManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly BookManagementDbContext _db;

        public HomeController(BookManagementDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult GioiThieu()
        {
            return View();
        }

        
        public IActionResult NDSach(int id)
        {
            ViewBag.BookId = id;
            return View();
        }
        
        public IActionResult NDChuong(int id)
        {
            Chapter Exsits = _db.Chapters.Where(x => x.ChapterId == id).FirstOrDefault();
            Chapter Item = Exsits;
            Item.TotalView = Item.TotalView + 1;
            _db.Entry(Exsits).State = EntityState.Detached;
            _db.Entry(Item).State = EntityState.Modified;
            _db.SaveChanges();

            ViewBag.ChapterId = id;
            return View();
        }

        public IActionResult TheLoai(int id)
        {
            ViewBag.CateId = id;
            return View();
        }

        public JsonResult TimKiem(string keyword)
        {
            Message msg = new Message();
            try
            {
                keyword = string.IsNullOrEmpty(keyword) ? "" : keyword.Trim();
                List<Book> booknew = _db.Books.Where(x => x.BookName.Contains(keyword)).OrderBy(x => x.ModifyTime).Take(5).ToList();
                List<Book> bookcompleted = _db.Books.Where(x => x.BookName.Contains(keyword) && x.IsCompleted == true).Take(5).ToList();

                //data = booknew
                msg.Data = booknew.Select(x => new { x.BookName, x.BookId, x.TotalChapter, x.BookImage, x.Author });
                //subdata = completed
                msg.SubData = bookcompleted.Select(x => new { x.BookName, x.BookId, x.TotalChapter, x.BookImage, x.Author });
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

        public IActionResult SachMoiCapNhat()
        {
            return View();
        }

        public IActionResult SachDaHoanThanh()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
