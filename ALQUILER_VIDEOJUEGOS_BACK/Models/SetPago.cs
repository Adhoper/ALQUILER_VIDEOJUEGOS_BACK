using Microsoft.EntityFrameworkCore;

namespace ALQUILER_VIDEOJUEGOS_BACK.Models
{
    [Keyless]
    public class SetPago
    {
        public int IdAlquiler { get; set; }
        public int IdUsuario { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaPago { get; set; }
        public string MetodoPago { get; set; }
        public string EstatusPago { get; set; }
    }
}
