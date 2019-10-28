using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmegenlerMvcTest.Models;
using Guard.Emegenler.FluentInterface.Policy;
using Guard.Emegenler.FluentInterface;
using System.Security.Claims;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

namespace EmegenlerMvcTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFluentApi API;
        public HomeController(IFluentApi api)
        {
            API = api;
        }
        public async Task<IActionResult> Index()
        {
            var identity = new ClaimsIdentity(new[] {
                                                new Claim(ClaimTypes.NameIdentifier, "1"),
                                                new Claim(ClaimTypes.Role, "Test"),
                                                new Claim(ClaimTypes.UserData, JsonConvert.SerializeObject(API.Policy.Take().FromUser("1")))
                                            }, CookieAuthenticationDefaults.AuthenticationScheme);

            var principal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal).ConfigureAwait(true);
            return View();
        }

        public IActionResult Privacy()
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
