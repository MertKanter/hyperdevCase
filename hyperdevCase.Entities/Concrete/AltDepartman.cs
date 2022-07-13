using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hyperdevCase.Entities.Abstract;

namespace hyperdevCase.Entities.Concrete
{
    public class AltDepartman:IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int altDepartmanID { get; set; }
        public Departman ustDepartmanID { get; set; }
        [StringLength(150)]
        public string altDepartmanAdi { get; set; }
    }
}
