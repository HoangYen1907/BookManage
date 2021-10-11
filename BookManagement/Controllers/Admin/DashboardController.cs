using BookManagement.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagement.Controllers.Admin
{
    public class DashboardController : Controller
    {
        private readonly BookManagementDbContext _db;
        public DashboardController(BookManagementDbContext db)
        {
            _db = db;
            
        }
        public IActionResult Index()
        {
            string us = HttpContext.Session.GetString("usname");
            if (string.IsNullOrEmpty(us))
                return Redirect("Account/Login");
            return View();
        }
    }
}
