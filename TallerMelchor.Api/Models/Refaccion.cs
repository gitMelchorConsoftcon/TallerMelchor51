using System.ComponentModel.DataAnnotations;

namespace TallerMelchor.Api.Models
{
    public class Refaccion
    {
        [Key]
        public int IdRefaccion { get; set; }
        
        [Required]
        [MaxLength(80)]
        public string Nombe { get; set; }

        [Required]
        public int IdCategoria { get; set; }

        [Required]
        public decimal PrecioVenta { get; set; }

        [Required]
        public decimal Existencia { get; set; }

        [Required]
        public bool Activo { get; set; }


    }
}
