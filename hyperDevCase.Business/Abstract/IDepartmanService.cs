using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hyperdevCase.Entities.Concrete;

namespace hyperDevCase.Business.Abstract
{
    public interface IDepartmanService
    {
        List<Departman> GetAllDepartman();

        Departman GetDepartmanById(int id);

        Departman CreateDepartman(Departman departman);

        Departman UpdateDepartman(Departman departman);

        void DeleteDepartmanById(int id);
    }
}
