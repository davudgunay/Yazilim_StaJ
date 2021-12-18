using System.ComponentModel.DataAnnotations;

namespace KutuphaneProg.Data.Model
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
