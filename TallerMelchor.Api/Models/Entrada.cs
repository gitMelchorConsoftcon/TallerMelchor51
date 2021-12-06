using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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


        [ForeignKey("IdProveedor")]
        public virtual Proveedor Proveedor { get; set; }
        public virtual List<EntradaDetalle>
            EntradaDetalle { get; set; }
    }
}
