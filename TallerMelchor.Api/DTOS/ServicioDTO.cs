using System.ComponentModel.DataAnnotations;

namespace TallerMelchor.Api.DTOS
{
    public class ServicioDTO
    {
        [Required]
        [MaxLength(90)]
        public string Nombre { get; set; }
    }
}
