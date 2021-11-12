using System.ComponentModel.DataAnnotations;
using TallerMelchor.Api.DTOS;

namespace TallerMelchor.Api.Models
{
    public class Marca
    {
        public Marca()
        {

        }
        public Marca(MarcaDTO nuevo)
        {
            Nombre = nuevo.Nombre;
            Activo = true;
        }

        [Key]
        public int IdMarca { get; set; }
        [Required]
        [MaxLength(40)]
        public string Nombre { get; set; }
        [Required]
        public bool Activo { get; set; }

    }
}
