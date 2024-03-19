using SWD_Proj.Models;
using SWD_Proj.Repositories;

namespace SWD_Proj.Services
{
    public class UserService
    {
        private UserRepo repo;
        public UserService()
        {
            repo = new UserRepo();
        }
        public User Login(string username, string password)
        {
            return repo.Login(username, password);
        }
    }
}
