using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmegenlerMvcPlayground.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmegenlerMvcPlayground.Controllers
{
    
    public class AuthController : Controller
    {
        // GET: Auth
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login([FromForm] LoginModel login)
        {
            return View();
        }

    }
}