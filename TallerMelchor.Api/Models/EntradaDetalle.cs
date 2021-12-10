using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TallerMelchor.Api.DTOS;

namespace TallerMelchor.Api.Models
{
    public class EntradaDetalle
    {

        public EntradaDetalle()
        {

        }

        public EntradaDetalle(EntradaDetalleDto nuevo)
        {
            this.IdRefaccion = nuevo.IdRefaccion;
            this.Cantidad=nuevo.Cantidad;
            this.Precio=nuevo.Precio;
            this.Activo = true;
        }


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
        public bool Activo { get; set; }

        [ForeignKey("IdEntrada")]
        public virtual Entrada 
            Entrada { get; set; }

        [ForeignKey("IdRefaccion")]
        public virtual Refaccion 
            Refaccion { get; set; }

    }
}
