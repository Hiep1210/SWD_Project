using SWD_Proj.Models;

namespace SWD_Proj.Repositories
{

    public class UserRepo
    {
        private SWDProjectContext con;
        public UserRepo()
        {
            con = new SWDProjectContext();
        }
        public User Login(string username, string password)
        {
            return con.Users.FirstOrDefault(x => x.Username == username && x.Password == password);
        }
    }
}
