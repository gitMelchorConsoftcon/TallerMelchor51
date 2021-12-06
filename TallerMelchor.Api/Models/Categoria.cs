using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TallerMelchor.Api.Models
{
    public class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        public bool Activo { get; set; }


        public virtual List<Refaccion> Reacciones { get; set; }
    }
}
