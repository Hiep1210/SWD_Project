using SWD_Proj.Models;

namespace SWD_Proj.Repositories
{
    public class JobRepo 
    {
        private SWDProjectContext con;
        public JobRepo()
        {
            con = new SWDProjectContext();
        }
        public List<Job> GetJobs(string name)
        {
            return con.Jobs.Where(x => (name == null) || ( x.Title.Contains(name))).ToList();
        }
    }
}
