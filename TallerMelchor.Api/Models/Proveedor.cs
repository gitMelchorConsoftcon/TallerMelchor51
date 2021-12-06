using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TallerMelchor.Api.Models
{
    public class Proveedor
    {

        [Key]
        public int IdProveedor { get; set; }

        [Required]
        [MaxLength(13)]
        public string RFC { get; set; }
        [Required]
        [MaxLength(90)]
        public string Nombre { get; set; }

        [MaxLength(10)]
        public string Telefono { get; set; }

        [MaxLength(120)]
        public string Correo { get; set; }

        [MaxLength(250)]
        public string Direccion { get; set; }

        [Required]
        public bool Activo { get; set; }


        public virtual List<Entrada> 
            Entradas { get; set; }

    }
}
