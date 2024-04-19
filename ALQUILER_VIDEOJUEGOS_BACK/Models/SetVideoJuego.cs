using Microsoft.EntityFrameworkCore;

namespace ALQUILER_VIDEOJUEGOS_BACK.Models
{
    [Keyless]
    public class SetVideoJuego
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int IdCategoriaVJ { get; set; }
        public string Estatus { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
    }
}
