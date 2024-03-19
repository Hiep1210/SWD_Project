using Microsoft.AspNetCore.Mvc;
using SWD_Proj.Services;

namespace SWD_Proj.Controllers
{
    public class UserController : Controller
    {
        UserService service;
        public UserController()
        {
            service = new UserService();
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(IFormCollection f)
        {
            var username = f["name"].ToString();
            var password = f["pass"].ToString();
            var p = service.Login(username, password);
            if (p == null)
            {
                TempData["message"] = "Wrong credentials";
                return View();
            }
            HttpContext.Session.SetInt32("user", p.UserId);
            return View("~/Views/Home/Index.cshtml");
        }
    }
}
