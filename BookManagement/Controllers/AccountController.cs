using BookManagement.Data;
using BookManagement.Models;
using Microsoft.AspNetCore.Mvc;
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

        
    }
}
