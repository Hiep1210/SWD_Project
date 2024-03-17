using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SWD_Proj.Models;

namespace SWD_Proj.Repositories
{
    public class CVRepo
    {
        private SWDProjectContext con;
        public CVRepo() { 
            con = new SWDProjectContext();
        }
        public void AddCV(Cv cv)
        {
            con.Cvs.Add(cv);
            con.SaveChanges();
        }
        public void EditCV(Cv cv)
        {
            using SWDProjectContext con = new SWDProjectContext();
            con.Cvs.Update(cv);
            con.SaveChanges();
        }
        public List<Cv> loadCv(int pID)
        {
            var cv = con.Cvs.Where(x => x.ProfileId == pID).ToList();
            return cv;
        }

    }
}
