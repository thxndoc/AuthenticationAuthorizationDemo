using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthDemo.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        [Authorize(Roles = "User")]
        public IActionResult User() => View();

        [Authorize(Roles = "Admin")]
        public IActionResult Admin() => View();
    }
}
