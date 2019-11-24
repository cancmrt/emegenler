using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using EmegenlerMvcPlayground.Context;
using EmegenlerMvcPlayground.Models;
using Guard.Emegenler.FluentInterface;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EmegenlerMvcPlayground.Controllers
{
    
    public class AuthController : Controller
    {
        private readonly IFluentApi API;
        private readonly PlaygroundContext _context;
        public AuthController(IFluentApi api, PlaygroundContext context)
        {
            API = api;
            _context = context;
        }
        // GET: Auth
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LoginAsync([FromForm] LoginModel login)
        {
            var user = _context.Set<User>().Where(user => user.Email == login.Email && user.Password == login.Password).FirstOrDefault();
            if(!(user is null))
            {
                var identity = new ClaimsIdentity(new[] {
                                                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                                                new Claim(ClaimTypes.UserData, JsonConvert.SerializeObject(API.Policy.Take().FromUser(user.Id.ToString())))
                                            }, CookieAuthenticationDefaults.AuthenticationScheme);

                var principal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal).ConfigureAwait(true);
                return RedirectToAction("Index","Home");
            }
            else
            {
                return RedirectToAction("Login");
            }
            
        }

    }
}