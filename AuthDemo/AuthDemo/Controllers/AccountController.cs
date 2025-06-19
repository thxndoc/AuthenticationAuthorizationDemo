using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using AuthDemo.Models;

namespace AuthDemo.Controllers
{
    public class AccountController : Controller
    {
        private List<UserModel> users = new()
        {
            new UserModel { Username = "admin", Password = "admin123", Role = "Admin" },
            new UserModel { Username = "user", Password = "user123", Role = "User" }
        };

        [HttpGet]
        public IActionResult Login() => View();

        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            var user = users.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user == null)
            {
                ViewBag.Error = "Invalid credentials";
                return View();
            }


        }
    }
}

