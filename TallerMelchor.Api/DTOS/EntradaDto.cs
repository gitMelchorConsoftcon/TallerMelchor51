using System.Collections.Generic;

namespace TallerMelchor.Api.DTOS
{
    public class EntradaDto
    {

        public  int IdProveedor { get; set; }
        public int Estado { get; set; }


        public  List<EntradaDetalleDto> Detalle { get; set; }

    }
    public class EntradaDetalleDto
    {
        public int IdRefaccion { get; set; }

        public double Cantidad { get; set; }

        public double Precio { get; set; }
    }


}
