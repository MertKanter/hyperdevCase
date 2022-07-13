using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hyperDevCase.Business.Abstract;
using hyperdevCase.DataAccess.Abstract;
using hyperdevCase.DataAccess.Concrete;
using hyperdevCase.Entities.Concrete;

namespace hyperDevCase.Business.Concrete
{
    public class DepartmanManager:IDepartmanService
    {
        private IDepartmanRepository _departmanRepository;

        public DepartmanManager()
        {
            _departmanRepository = new DepartmanRepository();
        }
        public List<Departman> GetAllDepartman()
        {
            return _departmanRepository.GetAllDepartman();
        }

        public Departman GetDepartmanById(int id)
        {
            return _departmanRepository.GetDepartmanById(id);
        }

        public Departman CreateDepartman(Departman departman)
        {
            return _departmanRepository.CreateDepartman(departman);
        }

        public Departman UpdateDepartman(Departman departman)
        {
            return _departmanRepository.UpdateDepartman(departman);
        }

        public void DeleteDepartmanById(int id)
        {
            _departmanRepository.DeleteDepartmanById(id);
        }
    }
}
