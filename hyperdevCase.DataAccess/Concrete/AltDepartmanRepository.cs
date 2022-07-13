using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hyperdevCase.DataAccess.Abstract;
using hyperdevCase.Entities.Concrete;

namespace hyperdevCase.DataAccess.Concrete
{
    public class AltDepartmanRepository:IAltDepartmanRepository
    {
        public List<AltDepartman> GetAllAltDepartman()
        {
            using (var hyperDbContext = new hyperDevCaseDBContext())
            {
                return hyperDbContext.AltDepartmanlar.ToList();
            }
        }

        public AltDepartman GetAltDepartmanById(int id)
        {
            using (var hyperDbContext = new hyperDevCaseDBContext())
            {
                return hyperDbContext.AltDepartmanlar.Find(id);
            }
        }

        public AltDepartman CreateAltDepartman(AltDepartman altDepartman)
        {
            using (var hyperDbContext = new hyperDevCaseDBContext())
            {
                hyperDbContext.AltDepartmanlar.Add(altDepartman);
                hyperDbContext.SaveChanges();
                return altDepartman;
            }
        }

        public AltDepartman UpdateAltDepartman(AltDepartman altDepartman)
        {
            using (var hyperDbContext = new hyperDevCaseDBContext())
            {
                hyperDbContext.AltDepartmanlar.Update(altDepartman);
                hyperDbContext.SaveChanges();
                return altDepartman;
            }
        }

        public void DeleteAltDepartmanById(int id)
        {
            using (var hyperDbContext = new hyperDevCaseDBContext())
            {
                var deleteAltDepartman = GetAltDepartmanById(id);
                hyperDbContext.AltDepartmanlar.Remove(deleteAltDepartman);
                hyperDbContext.SaveChanges();
            }
        }
    }
}
