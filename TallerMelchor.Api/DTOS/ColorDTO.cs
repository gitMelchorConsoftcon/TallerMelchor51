using System.ComponentModel.DataAnnotations;

namespace TallerMelchor.Api.DTOS
{
    public class ColorDTO
    {
        [MaxLength(15)]
        public string Nombre { get; set; }
    }
}
