using Microsoft.AspNetCore.Mvc;
using SWD_Proj.Models;
using SWD_Proj.Services;
using System.Diagnostics;

namespace SWD_Proj.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        SWDProjectContext con = new SWDProjectContext();
        private JobService jobService;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            jobService = new JobService();
        }

        public IActionResult Index()
        {
            return View(jobService.GetJobs(null));

        }
        public IActionResult Login()
        {
            return View();
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
