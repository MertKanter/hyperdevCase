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
    public class Departman:IEntity
    {
       
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int departmanID { get; set; }
        public Sirket departmanSirketID { get; set; }
        [StringLength(150)]
        public string departmanAdi { get; set; }
    }
}
