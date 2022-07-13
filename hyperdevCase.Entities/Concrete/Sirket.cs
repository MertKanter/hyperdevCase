using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using hyperdevCase.Entities.Abstract;

namespace hyperdevCase.Entities.Concrete
{
    public class Sirket:IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int sirketID { get; set; }
        [StringLength(150)]
        public string sirketAdi { get; set; }
        [StringLength(50)]
        public string sirketTur { get; set; }
        [StringLength(150)]
        public string sirketVD { get; set; }
        [StringLength(10)]
        public string sirketVNO { get; set; }
        [StringLength(50)]
        public string sirketIl { get; set; }
        [StringLength(50)]
        public string sirketIlce { get; set; }
        [StringLength(250)]
        public string sirketAdres { get; set; }
    }
}