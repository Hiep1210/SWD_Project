using Microsoft.AspNetCore.Mvc;
using SWD_Proj.Models;
using System.Diagnostics;

namespace SWD_Proj.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        SWDProjectContext con = new SWDProjectContext();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
            
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(IFormCollection f)
        {
            var username = f["name"].ToString();
            var password = f["pass"].ToString();
            var p = con.Users.FirstOrDefault(x => x.Username == username && x.Password == password);
            if (p == null)
            {
                TempData["message"] = "Wrong credentials";
                return View();
            }
            HttpContext.Session.SetInt32("user", p.UserId); 
            return RedirectToAction("Index");
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
