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

    }
}
