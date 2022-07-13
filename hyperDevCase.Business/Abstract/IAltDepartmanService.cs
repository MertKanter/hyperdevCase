using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hyperdevCase.Entities.Concrete;

namespace hyperDevCase.Business.Abstract
{
    public interface IAltDepartmanService
    {
        List<AltDepartman> GetAllAltDepartman();

        AltDepartman GetAltDepartmanById(int id);

        AltDepartman CreateAltDepartman(AltDepartman altDepartman);

        AltDepartman UpdateAltDepartman(AltDepartman altDepartman);

        void DeleteAltDepartmanById(int id);
    }
}
