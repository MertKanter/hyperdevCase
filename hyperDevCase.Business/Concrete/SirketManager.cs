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
    public class SirketManager:ISirketService
    {
        private ISirketRepository _sirketRepository;

        public SirketManager()
        {
            _sirketRepository = new SirketRepository();
        }
        public List<Sirket> GetAllSirket()
        {
            return _sirketRepository.GetAllSirket();
        }

        public Sirket GetSirketById(int id)
        {
            return _sirketRepository.GetSirketById(id);
        }

        public Sirket CreateSirket(Sirket sirket)
        {
            return _sirketRepository.CreateSirket(sirket);
        }

        public Sirket UpdateSirket(Sirket sirket)
        {
            return _sirketRepository.UpdateSirket(sirket);
        }

        public void DeleteSirketById(int id)
        {
            _sirketRepository.DeleteSirketById(id);
        }
    }
}
