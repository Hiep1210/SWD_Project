using Microsoft.AspNetCore.Mvc;
using SWD_Proj.Models;
using SWD_Proj.Services;

namespace SWD_Proj.Controllers
{
    public class CVController : Controller
    {
        CVService service;
        public CVController()
        {
            service = new CVService();
        }
        [HttpPost]
        public IActionResult Index(IFormCollection f)
        {
            string title = f["title"].ToString();
            string content = f["content"].ToString();
            Cv cv = new Cv();
            cv.Title = title;
            cv.Content = content;
            cv.Cvid = int.Parse(f["cvid"].ToString());
            cv.ProfileId = int.Parse(f["id"].ToString());
            if (service.getCVList(cv.ProfileId ?? 0).Count == 0)
                service.addCV(cv);
            else service.editCV(cv);
            return RedirectToAction("Profile","Profile");
        }


    }
}
