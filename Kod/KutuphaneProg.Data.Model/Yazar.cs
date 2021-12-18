using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KutuphaneProg.Data.Model
{
    public class Yazar: BaseEntity
    {
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Ad { get; set; }

        public virtual  List<Kitap> Kİtaplar { get; set; }
    }
}
