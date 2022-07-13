using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hyperdevCase.DataAccess.Abstract;
using hyperdevCase.Entities.Concrete;

namespace hyperdevCase.DataAccess.Concrete
{
    public class SirketRepository:ISirketRepository
    {

        public List<Sirket> GetAllSirket()
        {
            using (var hyperDbContext = new hyperDevCaseDBContext())
            {
                return hyperDbContext.Sirketler.ToList();
            }
        }

        public Sirket GetSirketById(int id)
        {
            using (var hyperDbContext = new hyperDevCaseDBContext())
            {
                return hyperDbContext.Sirketler.Find(id);
            }
        }

        public Sirket CreateSirket(Sirket sirket)
        {
            using (var hyperDbContext = new hyperDevCaseDBContext())
            {
                hyperDbContext.Sirketler.Add(sirket);
                hyperDbContext.SaveChanges();
                return sirket;
            }
        }

        public Sirket UpdateSirket(Sirket sirket)
        {
            using (var hyperDbContext = new hyperDevCaseDBContext())
            {
                hyperDbContext.Sirketler.Update(sirket);
                hyperDbContext.SaveChanges();
                return sirket;
            }
        }

        public void DeleteSirketById(int id)
        {
            using (var hyperDbContext = new hyperDevCaseDBContext())
            {
                var deleteSirket = GetSirketById(id);
                hyperDbContext.Sirketler.Remove(deleteSirket);
                hyperDbContext.SaveChanges();
            }
        }
    }
}
