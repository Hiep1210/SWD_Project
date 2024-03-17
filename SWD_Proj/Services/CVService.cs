using SWD_Proj.Repositories;
using SWD_Proj.Models;
namespace SWD_Proj.Services
{
    public class CVService
    {
        private CVRepo repo;
        public CVService() {
            repo = new CVRepo();
        }
        public void addCV(Cv cv)
        {
            repo.AddCV(cv);
        }
        public void editCV(Cv cv)
        {
            repo.EditCV(cv);
        }
        public List<Cv> getCVList(int PID)
        {
            return repo.loadCv(PID);
        }
    }
}
