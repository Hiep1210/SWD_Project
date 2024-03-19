using SWD_Proj.Models;
using SWD_Proj.Repositories;

namespace SWD_Proj.Services
{
    public class JobService 
    {
        private JobRepo repo;
        public JobService()
        {
            repo = new JobRepo();
        }
        public List<Job> GetJobs(string name)
        {
            return repo.GetJobs(name);
        }
    }
}
