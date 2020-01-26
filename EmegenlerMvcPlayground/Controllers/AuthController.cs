using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using EmegenlerMvcPlayground.Context;
using EmegenlerMvcPlayground.Models;
using Guard.Emegenler.FluentInterface;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EmegenlerMvcPlayground.Controllers
{
    
    public class AuthController : Controller
    {
        private readonly IEmegenlerFluentApi API;
        private readonly PlaygroundContext _context;
        public AuthController(IEmegenlerFluentApi api,PlaygroundContext context)
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
        public async Task<IActionResult> Login([FromForm] LoginModel login)
        {
            var user = _context.Set<User>()
                .Where(user => user.Email == login.Email && user.Password == login.Password)
                .Select(u => new User{
                    Id = u.Id,
                    Email = u.Email,
                    Name = u.Name,
                    Surname = u.Surname,
                    Password = u.Password,
                    Groups = u.Groups
                })
                .FirstOrDefault();
            if(!(user is null))
            {
                var UserPolicies = API.Policy.Take().FromUser(user.Id.ToString()).ToList();
                foreach(var group in user.Groups)
                {
                    UserPolicies.AddRange(API.Policy.Take().FromRole(group.GroupId.ToString()));
                }

                var identity = new ClaimsIdentity(new[] {
                                                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                                                new Claim(ClaimTypes.UserData, JsonConvert.SerializeObject(UserPolicies))
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
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }


    }
}