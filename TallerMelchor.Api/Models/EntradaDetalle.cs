using System.ComponentModel.DataAnnotations;

namespace TallerMelchor.Api.Models
{
    public class EntradaDetalle
    {
        [Key]
        public int IdEntradaDetalle { get; set; }
        
        [Required]
        public int IdEntrada { get; set; }
        
        [Required]
        public int IdRefaccion { get; set; }
        
        [Required]
        [Range(0,double.MaxValue)]
        public double Cantidad { get; set; }
        
        [Required]
        [Range(0, double.MaxValue)]
        public double Precio { get; set; }

        [Required]
        public int Estatus { get; set; }

        [Required]
        public bool Activo { get; set; }

    }
}
