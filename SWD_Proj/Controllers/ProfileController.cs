using Microsoft.AspNetCore.Mvc;
using SWD_Proj.Models;
using SWD_Proj.Repositories;
using SWD_Proj.Services;
using System.Text.RegularExpressions;

namespace SWD_Proj.Controllers
{
    public class ProfileController : Controller
    {
        private ProfileService service;
        public Profile p;
        public ProfileController()
        {
            this.service = new ProfileService();
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Profile()
        {
            int? id = HttpContext.Session.GetInt32("user");
            if (id == null)
            {
                TempData["message"] = "Please Login";
                return Redirect("/Home/Login");
            }
            p = service.loadProfile(id ?? 0);
            return View(p);
        }
        [HttpPost]
        public IActionResult Profile(Profile p)
        {
            int? id = HttpContext.Session.GetInt32("user");
            if (p.FullName != null)
            {
                if (p.FullName.Length > 3)
                {
                    TempData["message"] = "Please enter at least 4 letters for Full Name";
                    return Redirect("/Home/Index");
                }
            }
            var regex = new Regex(@"^\d+$");
            if (!regex.IsMatch(p.Phone) || p.Phone.Length != 10)
            {
                TempData["message"] = "Wrong phone number format";
                return Redirect("/Home/Index");
            }
            if (p.ProfileId == 0)
            {
                service.addProfile(p);
            }
            else
            {
                service.updateProfile(p);
            }
            return RedirectToAction("Profile");
        }
    }
}
