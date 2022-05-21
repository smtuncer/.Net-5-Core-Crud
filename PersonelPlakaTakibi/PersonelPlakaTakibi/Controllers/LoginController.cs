using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PersonelPlakaTakibi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PersonelPlakaTakibi.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(Admin p)
        {
            var dataValue = db.Admins.FirstOrDefault(i => i.AdminUsername == p.AdminUsername && i.AdminPassword == p.AdminPassword);
            if (dataValue != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.AdminUsername)
                };
                var userIdentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }
    }
}
