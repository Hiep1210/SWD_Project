using SWD_Proj.Models;
using SWD_Proj.Repositories;

namespace SWD_Proj.Services
{
    public class ProfileService
    {
        private ProfileRepo repo;
        public ProfileService() {
            this.repo = new ProfileRepo();
        }
        public Profile loadProfile(int userId)
        {
            return repo.loadProfile(userId);
        }
        public void updateProfile(Profile p)
        {
            repo.updateProfile(p);
        }

        public void addProfile(Profile p)
        {
            repo.addProfile(p);
        }
    }
}
