using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Range(0, 10000)]
        public decimal Precio { get; set; }

        public string Descripcion { get; set; }
    }
}
