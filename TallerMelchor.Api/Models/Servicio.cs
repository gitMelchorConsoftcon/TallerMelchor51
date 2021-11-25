using System.ComponentModel.DataAnnotations;
using TallerMelchor.Api.DTOS;

namespace TallerMelchor.Api.Models
{
    public class Servicio
    {

        public Servicio()
        {
                
        }

        public Servicio(ServicioDTO nuevo)
        {
            this.Nombre=nuevo.Nombre;
            this.Activo = true;
        }

        [Key]
        public int IdServicio { get; set; }

        [Required]
        [MaxLength(90)]
        public string Nombre { get; set; }

        [Required]
        public bool Activo { get; set; }
    }
}
