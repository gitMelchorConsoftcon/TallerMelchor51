using System;
using System.ComponentModel.DataAnnotations;

namespace TallerMelchor.Api.Models
{
    public class Entrada
    {
        [Key]
        public int IdEntrada { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public int IdProveedor { get; set; }

        [Required]
        public int Estatus { get; set; }

        [Required]
        public bool Activo { get; set; }
    }
}
