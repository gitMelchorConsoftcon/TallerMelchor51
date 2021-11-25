using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TallerMelchor.Api.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }

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

        public virtual List<Vehiculo> Vehiculos { get; set; }

    }
}
