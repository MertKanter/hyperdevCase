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
    public class AltDepartmanManager:IAltDepartmanService
    {
        private IAltDepartmanRepository _altDepartmanRepository;

        public AltDepartmanManager()
        {
            _altDepartmanRepository = new AltDepartmanRepository();
        }
        public List<AltDepartman> GetAllAltDepartman()
        {
            return _altDepartmanRepository.GetAllAltDepartman();
        }

        public AltDepartman GetAltDepartmanById(int id)
        {
            return _altDepartmanRepository.GetAltDepartmanById(id);
        }

        public AltDepartman CreateAltDepartman(AltDepartman altDepartman)
        {
            return _altDepartmanRepository.CreateAltDepartman(altDepartman);
        }

        public AltDepartman UpdateAltDepartman(AltDepartman altDepartman)
        {
            return _altDepartmanRepository.UpdateAltDepartman(altDepartman);
        }

        public void DeleteAltDepartmanById(int id)
        {
            _altDepartmanRepository.DeleteAltDepartmanById(id);
        }
    }
}
