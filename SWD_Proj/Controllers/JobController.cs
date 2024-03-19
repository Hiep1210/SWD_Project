using Microsoft.AspNetCore.Mvc;
using SWD_Proj.Models;
using SWD_Proj.Services;

namespace SWD_Proj.Controllers
{
    public class JobController : Controller
    {
        public string JobName;
        private JobService service;
        public JobController()
        {
            service = new JobService();
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult JobSearch(string JobName)
        {
            this.JobName = JobName;
            List<Job> list = service.GetJobs(JobName);
            return View("~/Views/Home/Index.cshtml", list);
        }
    }
}
