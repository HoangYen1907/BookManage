using BookManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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
            ViewBag.ChapterId = id;
            return View();
        }

        public IActionResult TheLoai(int id)
        {
            ViewBag.CateId = id;
            return View();
        }

        public IActionResult TimKiem(int key)
        {
            ViewBag.Key = key;
            return View();
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
