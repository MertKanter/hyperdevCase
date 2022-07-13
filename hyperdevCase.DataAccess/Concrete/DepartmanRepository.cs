using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hyperdevCase.DataAccess.Abstract;
using hyperdevCase.Entities.Concrete;

namespace hyperdevCase.DataAccess.Concrete
{
    public class DepartmanRepository:IDepartmanRepository
    {
        public List<Departman> GetAllDepartman()
        {
            using(var hyperDbContext = new hyperDevCaseDBContext())
            {
                return hyperDbContext.Departmanlar.ToList();
            }
        }

        public Departman GetDepartmanById(int id)
        {
            using (var hyperDbContext = new hyperDevCaseDBContext())
            {
                return hyperDbContext.Departmanlar.Find(id);
            }
        }

        public Departman CreateDepartman(Departman departman)
        {
            using (var hyperDbContext = new hyperDevCaseDBContext())
            {
                hyperDbContext.Departmanlar.Add(departman);
                hyperDbContext.SaveChanges();
                return departman;
            }
        }

        public Departman UpdateDepartman(Departman departman)
        {
            using (var hyperDbContext = new hyperDevCaseDBContext())
            {
                hyperDbContext.Departmanlar.Update(departman);
                hyperDbContext.SaveChanges();
                return departman;
            }
        }

        public void DeleteDepartmanById(int id)
        {
            using (var hyperDbContext = new hyperDevCaseDBContext())
            {
                var deleteDepartman = GetDepartmanById(id);
                hyperDbContext.Departmanlar.Remove(deleteDepartman);
                hyperDbContext.SaveChanges();
            }
        }
    }
}
