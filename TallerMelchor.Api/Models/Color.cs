using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TallerMelchor.Api.DTOS;

namespace TallerMelchor.Api.Models
{
    public class Color
    {

        public Color()
        {

        }

        public Color(ColorDTO nuevo)
        {
            this.Nombre = nuevo.Nombre;
            this.Activo = true;
        }

        [Key]
        public int IdColor { get; set; }

        [Required]
        [MaxLength(15)]
        public string Nombre { get; set; }

        [Required]
        public bool Activo { get; set; }

        public virtual List<Vehiculo> Vehiculos { get; set; }
    }
}
