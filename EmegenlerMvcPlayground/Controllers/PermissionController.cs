using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Guard.Emegenler.FluentInterface;
using Microsoft.AspNetCore.Mvc;

namespace EmegenlerMvcPlayground.Controllers
{
    public class PermissionController : Controller
    {
        private readonly IFluentApi API;
        public PermissionController(IFluentApi api)
        {
            API = api;
        }
        public IActionResult Index()
        {
            //API.Policy.Take(
            return View();
        }
    }
}