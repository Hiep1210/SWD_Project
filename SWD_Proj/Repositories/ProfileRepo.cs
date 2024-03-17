using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SWD_Proj.Models;

namespace SWD_Proj.Repositories
{
    public class ProfileRepo
    {
        private SWDProjectContext con;
        public ProfileRepo()
        {
            this.con = new SWDProjectContext();
        }
        public Profile loadProfile(int userId)
        {
            Profile p = con.Profiles.Include(x => x.Cvs).FirstOrDefault(x => x.UserId == userId);
            return p;
        }
        public void updateProfile(Profile p)
        {
            con.Profiles.Update(p);
            con.SaveChanges();
        }
        
        public void addProfile(Profile p)
        {
            con.Profiles.Add(p);
            con.SaveChanges();
        }


    }
}
