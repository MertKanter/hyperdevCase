using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hyperdevCase.Entities.Concrete;

namespace hyperDevCase.Business.Abstract
{
    public interface ISirketService
    {
        List<Sirket> GetAllSirket();

        Sirket GetSirketById(int id);

        Sirket CreateSirket(Sirket sirket);

        Sirket UpdateSirket(Sirket sirket);

        void DeleteSirketById(int id);
    }
}
