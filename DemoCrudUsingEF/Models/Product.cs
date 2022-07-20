using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoCrudUsingEF.Models
{
    [Table("product")]
    public class Product
    {
        [Key]
        [Required(ErrorMessage ="Enter ID")]
        public int ID { get; set; }
        [Required(ErrorMessage ="Name Required")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Price Required")]
        public int Price { get; set; }
    }
}
